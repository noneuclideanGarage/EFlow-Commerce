# EFlow-Commerce

EventFlow Commerce is a production-inspired, event-driven order processing platform built with .NET.

The project demonstrates backend engineering practices such as distributed messaging, transactional outbox, optimistic concurrency, integration testing, observability, and containerized local development.

## Architecture

The system consists of several independently deployable services:

- Catalog API
- Orders API
- Payments Worker
- API Gateway

Services communicate asynchronously through RabbitMQ using integration events.

## Current status

Milestone 1 completed:
- Orders API
- Create order
- Get order by id
- PostgreSQL persistence
- EF Core migrations
- Integration tests with Testcontainers
- Database reset with Respawn

## Planned milestones

- Catalog API
- RabbitMQ messaging
- Transactional outbox
- Payments Worker
- Observability
