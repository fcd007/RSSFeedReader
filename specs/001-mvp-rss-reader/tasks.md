# Tasks: MVP RSS Reader

**Input**: Design documents from `/specs/001-mvp-rss-reader/`

**Prerequisites**: plan.md (required), spec.md (required for user stories), research.md, data-model.md, contracts/

## Phase 1: Setup (Shared Infrastructure)

**Purpose**: Create the initial backend/frontend structure for the MVP

- [ ] T001 Create backend and frontend project folders per implementation plan
- [ ] T002 Initialize ASP.NET Core Web API backend project with minimal configuration
- [ ] T003 Initialize Blazor WebAssembly frontend project with minimal configuration
- [ ] T004 [P] Add shared project conventions for models, services, and UI structure

---

## Phase 2: Foundational (Blocking Prerequisites)

**Purpose**: Establish the in-memory subscription flow and basic API/UI connectivity

- [ ] T005 Create subscription model in backend/src/Models/Subscription.cs
- [ ] T006 Create in-memory subscription service in backend/src/Services/SubscriptionService.cs
- [ ] T007 Implement API controller for adding and listing subscriptions in backend/src/Controllers/SubscriptionsController.cs
- [ ] T008 Configure backend CORS for the frontend origin in backend/src/Program.cs
- [ ] T009 Configure frontend API base URL in frontend/src/wwwroot/appsettings.json
- [ ] T010 [P] Create shared UI service for subscriptions in frontend/src/Services/SubscriptionApiService.cs

**Checkpoint**: Foundation ready - the UI and API can communicate for the subscription workflow

---

## Phase 3: User Story 1 - Add a feed subscription (Priority: P1) 🎯 MVP

**Goal**: Let a user add a feed subscription and see it appear in the list

**Independent Test**: A user can enter a feed address, submit it, and see the subscription appear immediately in the main view

### Implementation for User Story 1

- [ ] T011 [P] [US1] Create subscription form component in frontend/src/Components/SubscriptionForm.razor
- [ ] T012 [US1] Create subscriptions page in frontend/src/Pages/Subscriptions.razor
- [ ] T013 [US1] Wire the form and page to the subscription API service in frontend/src/Pages/Subscriptions.razor
- [ ] T014 [US1] Add validation and duplicate handling in backend/src/Services/SubscriptionService.cs
- [ ] T015 [US1] Add clear user feedback for empty or duplicate submissions in frontend/src/Pages/Subscriptions.razor
- [ ] T016 [US1] Verify the subscription list updates immediately after add in the UI

**Checkpoint**: At this point, User Story 1 should be fully functional and testable independently

---

## Phase 4: User Story 2 - Review subscriptions in the list (Priority: P2)

**Goal**: Show the current list of subscriptions clearly in the main interface

**Independent Test**: A user can open the main view and see all current subscriptions in a readable list

### Implementation for User Story 2

- [ ] T017 [P] [US2] Create subscription list display component in frontend/src/Components/SubscriptionList.razor
- [ ] T018 [US2] Render the current subscription collection from the API response in frontend/src/Pages/Subscriptions.razor
- [ ] T019 [US2] Ensure the list remains visible and readable after repeated additions

**Checkpoint**: At this point, User Stories 1 and 2 should both work independently

---

## Phase 5: Polish & Cross-Cutting Concerns

**Purpose**: Improve clarity and verify the MVP end to end

- [ ] T020 [P] Update documentation for the MVP workflow in specs/001-mvp-rss-reader/quickstart.md
- [ ] T021 Run the backend and frontend locally to verify the add-and-list workflow
- [ ] T022 Review configuration and route setup for the local development experience
- [ ] T023 [P] Clean up any temporary or placeholder code introduced during the MVP setup

---

## Dependencies & Execution Order

### Phase Dependencies

- **Setup (Phase 1)**: No dependencies - can start immediately
- **Foundational (Phase 2)**: Depends on Setup completion - blocks the user stories
- **User Stories (Phase 3+)**: Depend on Foundational completion
- **Polish (Phase 5)**: Depends on all desired user stories being complete

### User Story Dependencies

- **User Story 1 (P1)**: Can start after Foundational - no dependencies on other stories
- **User Story 2 (P2)**: Can start after Foundational and may build on US1 behavior

### Parallel Opportunities

- T004 can run in parallel with initial project setup tasks
- The frontend and backend project initialization tasks can be done in parallel if needed
- UI components for US1 and US2 can be developed in parallel once the shared service is available
