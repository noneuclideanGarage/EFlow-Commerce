# EFlow-Commerce

EventFlow Commerce is a production-inspired, event-driven order processing platform built with .NET.

The project demonstrates backend engineering practices such as distributed messaging, transactional outbox, optimistic concurrency, integration testing, observability, and containerized local development.

## Current status

Milestone 1 completed:
- Orders API
- Create order
- Get order by id
- PostgreSQL persistence
- EF Core migrations
- Vertical Slice structure
- FluentValidation via decorator pipeline
- Integration tests with Testcontainers
- DB cleanup with Respawn

## Roadmap

Milestone 2:
- Catalog API
- Product model
- Product lookup
- Validate products before order creation

Milestone 3:
- RabbitMQ
- Payments Worker
- Integration events

Milestone 4:
- Transactional Outbox
- Observability
- CI/CD
