SchoolSystem.Domain 🏫📚

The domain layer for the SchoolSystem platform. This repository contains the core business logic, entities, and rules that define how a school system operates — completely independent of any framework, database, or infrastructure concern.

Responsibilities 🧠

Entities — Core objects of the system: Student, Teacher, Course, Enrollment, Grade, and related models with their business rules and invariants enforced at the model level.

Domain Logic — Business rules that live at the heart of the application, such as enrollment eligibility, grade calculation policies, and course capacity constraints.

Interfaces & Abstractions — Contracts (e.g., repository interfaces) that the backend implements, ensuring the domain has no dependency on infrastructure or frameworks.

Value Objects & Enums — Strongly typed primitives like StudentId, GradeLevel, or EnrollmentStatus that make intent explicit and reduce bugs.

Architecture 🏗️

This is a pure domain library — it has no dependencies on external frameworks, databases, or HTTP concerns. It is consumed by SchoolSystem.Backend
 and is designed to be independently testable.

```
SchoolSystem.Domain
├── Entities/        # Core domain models
├── ValueObjects/    # Strongly-typed domain primitives
├── Interfaces/      # Repository and service contracts
└── Enums/   # Domain-specific enumerations
```


Getting Started 🚀
git clone https://github.com/AbayleE/SchoolSystem.Domain.git
cd SchoolSystem.Domain

# Restore and build

```
dotnet restore
dotnet build
```



This library is not run standalone — it is referenced as a dependency by SchoolSystem.Backend.

Related Repositories 🔗

SchoolSystem.Backend
 — API and application layer that consumes this domain
