# ControleCerto API - Instrucoes para IA

## Objetivo
- Manter este arquivo curto e pratico: ele deve orientar organizacao, padroes de codigo e criterios de implementacao.
- Antes de criar, migrar, corrigir ou refatorar uma funcionalidade, olhar exemplos existentes no projeto e preservar o estilo atual.

## Organizacao de funcionalidades
- Manter o maximo possivel o padrao REST na criacao de rotas: recursos no plural, verbos HTTP corretos, ids na rota e filtros/paginacao via query string.
- Novas funcionalidades relevantes devem nascer como modulo em `ControleCerto.Api/Modules/[TituloDaFuncionalidade]`.
- Dentro de cada modulo, criar apenas as subpastas necessarias, seguindo este padrao: `Controllers`, `Decorators`, `DTOs`, `Models`, `Services`, `Validations`, etc.
- DTOs de entrada devem terminar com `Request`; DTOs de saida devem terminar com `Response`.
- Todo DTO `Request` novo deve ter um validator correspondente em `Validations`, usando FluentValidation e mensagens em portugues.
- `ControleCerto.Api/Validations` e pastas raiz como `Controllers`, `DTOs` e `Services` sao legado para funcionalidades antigas. Em desenvolvimento novo, coloque os arquivos dentro do modulo; use a raiz apenas quando o codigo realmente for compartilhado e nao pertencer a nenhum modulo especifico.

## Pastas raiz compartilhadas
- `Bus`: consumers e integracoes assincronas via MassTransit/RabbitMQ.
- `CronJobs`: jobs agendados e hosted services, hoje ligados ao Hangfire.
- `Decorators`: atributos/filtros reutilizaveis, como extracao de informacoes do token.
- `Errors`: `AppError`, `ErrorResponse` e Result pattern.
- `Extensions`: extension methods e configuracoes reutilizaveis de aplicacao, migracoes e retorno de Result.
- `Middleware`: middlewares globais da pipeline HTTP.
- `Utils`: utilitarios pequenos e independentes de dominio especifico.

## Result pattern
- Servicos devem retornar `Result<T>` quando existe payload de sucesso.
- Servicos sem payload de sucesso devem retornar `Result`, nao `Result<bool>`.
- Para sucesso sem payload, retornar `Result.Success()`.
- Para erro, retornar `new AppError("Mensagem em portugues.", ErrorTypeEnum.X)`.
- Controllers devem converter resultados com `HandleReturnResult()`. `Result<T>` retorna `200 OK` com payload; `Result` sem tipo retorna `204 No Content` quando sucesso.

## Criterio de pronto
- Codigo compila com `dotnet build`.
- Testes relevantes passam com `dotnet test`, quando aplicavel.
- Mudancas ficam restritas ao escopo solicitado e preservam contratos publicos, migrations, DTOs, validators e testes relacionados.
