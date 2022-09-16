# Padrão de projetos em REST

## 1. Entities

Aqui neste pacote, também chamado por vezes de `Domain` vamos modelar de modo geral as entidades do sistema. Uma modelagem contém:

1. atributos
2. métodos
3. composições (1:1, 1:n, n:n)
4. heranças

## 2. Repositories

Aqui criamos a ponte com o banco de dados e produzimos uma interface que cumpre todo os comandos mais recorrentes em Banco de Dados. (salvar, retornar todos, encontrar por id, deletar)

## 3. Serviços

Aqui nosso objetivo é injetar os bancos como atributos destes serviços e posteriormente usar este serviço.

### Por que não usar diretamente o repositório ?

O repositório usado diretamente não trata erros e pode deixar uma manipulação pior espalhada pelo código.

O serviço injeta os repositórios necessários e costuma receber e retornar DTO's para os controladores.

## 4. DTO's

São classes que fragmentam a classe principal e selecionam os campos adequados para um request ou uma response

## 5. Controlador (API)

É quem recebe os verbos HTTP e a rota, para retornar ou receber o arquivo em modelo de informação (`json`)
