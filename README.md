# TDD Password Validator

Repositório para prática de **TDD (Test Driven Development)** em C#, incluindo refatoração e CI/CD.

## Estrutura

- `PasswordValidator/` → código de produção
- `PasswordValidatorTests/` → testes xUnit
- `.github/workflows/` → configuração de CI/CD
- `README.md` → instruções e objetivo

## Como rodar localmente

```bash
dotnet restore
dotnet build
dotnet test
```