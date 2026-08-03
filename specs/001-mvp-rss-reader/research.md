# Research: MVP RSS Reader

## Decision

Use a minimal ASP.NET Core Web API backend and a Blazor WebAssembly frontend, with an in-memory subscription store for the MVP.

## Rationale

This choice aligns with the stakeholder documents and the existing project direction. It keeps the first release simple while preserving a clear path to future enhancements such as feed fetching and persistence.

## Alternatives considered

- A single-page app with only a frontend service: rejected because the stakeholder documents already define a backend/frontend split and the MVP should demonstrate a simple API boundary.
- A full production-grade architecture with database and background processing: rejected because it would exceed the MVP scope and add unnecessary complexity.
