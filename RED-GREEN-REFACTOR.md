# Ciclo RED–GREEN–REFACTOR

- **RED:** Os testes foram escritos antes da implementação e falharam porque o serviço `PasswordValidator` ainda não existia.
- Foram preparados seis casos: senha válida, menos de oito caracteres, sem maiúscula, sem número, `null` e vazia.
- **GREEN:** A validação passou a aceitar apenas senhas com pelo menos oito caracteres, uma letra maiúscula e um número.
- As entradas `null` e vazia também são rejeitadas.
- **REFACTOR:** O validador foi isolado em uma biblioteca .NET 10 compartilhada.
- O MVC e o projeto NUnit referenciam a biblioteca, sem os testes dependerem do projeto Web executável.
- Essa separação mantém a regra testável e elimina a cópia problemática do `runtimeconfig.json` do MVC.
- A validação final dos seis testes e do build está registrada após sua execução neste ambiente.
