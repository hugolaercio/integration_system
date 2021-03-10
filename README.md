Tarefas

OK *Definir contrato de integração para fornecedor (Para permitir iniciar desenvolvimento dos 3 containers)

OK *Desenvolver infraestrura compartilhada do projeto para desenvolvimento dos containers

OK *Desenvolvimento do container [POC-ADAPTADER-PRODUCER] (container de adapter) lendo da base SQL Server e enviando com uma base mockada e enviando para o broker (mockado)

*Desenvolvimento do container [POC-ADAPTADER-TRANSLATOR] (Container de tradução com a Decoupling Layer) lendo da fila mockada e enviando para o mongodb (mockado)

*Desenvolvimento do container de consulta [POC-FORNEC-QUERY] da base de dados do mongodb (mockada) e retorno dos dados via REST com swagger ativo e mecanismo de autenticacao

*Criação do Container Banco de dados SQL Server com tabela e dados

*Criação do Container de Mensageria (RabbitMQ) e filas 

*Criação do Container de Redis

*Criação do Container de Mongo DB com o documento de fornecedor

*Implementação do codigo de cada camada efetivo conectando nos componentes arquiteturais da infra estrutura (SQL Server, Rabbit MQ, Mongo DB, Redis)


ENTREGAVEIS

OK 1) Projeto com modelo de fornecedor (contrato de integração) e estruturas compartilhadas de infraestrutura 
2) Container de banco de dados SQL Server populado e Container [POC-ADAPTADER-PRODUCER] 
3) Container do RabbitMQ e Container [POC-ADAPTADER-TRANSLATOR] 
4) Container do Redis e MongoDB e container do [POC-FORNEC-QUERY]

Possibilidade de trabalho

Com a estrutura do contrato de fornecedor definida e a infraestrutura do projeto é possivel que 3 desenvolvedores iniciem o 
projeto em paralelo desenvolvendo os 3 micro serviços seguindo o contrato e modelo de classe de fornecedor, realizando o desenvolvimento com mocks e testes unitarios, no final
realizando o teste integrado de todos os componentes

# integration_system