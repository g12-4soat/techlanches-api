<p dir="auto"><img src="https://github.com/g12-4soat/tech-lanches/blob/main/src/TechLanches/Adapter/Driver/TechLanches.Adapter.API/wwwroot/SwaggerUI/images/android-chrome-192x192.png" alt="TECHLANCHES" title="TECHLANCHES" align="right" height="60" style="max-width: 100%;"></p>

# Tech Lanches

Repositório dedicado ao projeto TechChallenge da FIAP - Turma 4SOAT

## Problema

Há uma lanchonete de bairro que está expandindo devido seu grande sucesso. Porém, com a expansão e sem um sistema de controle de pedidos, o atendimento aos clientes pode ser caótico e confuso. Por exemplo, imagine que um cliente faça um pedido complexo, como um hambúrguer personalizado com ingredientes específicos, acompanhado de batatas fritas e uma bebida. O atendente pode anotar o pedido em um papel e entregá-lo à cozinha, mas não há garantia de que o pedido será preparado corretamente.

Sem um sistema de controle de pedidos, pode haver confusão entre os atendentes e a cozinha, resultando em atrasos na preparação e entrega dos pedidos. Os pedidos podem ser perdidos, mal interpretados ou esquecidos, levando à insatisfação dos clientes e a perda de negócios.

Em resumo, um sistema de controle de pedidos é essencial para garantir que a lanchonete possa atender os clientes de maneira eficiente, gerenciando seus pedidos e estoques de forma adequada. Sem ele, expandir a lanchonete pode acabar não dando certo, resultando em clientes insatisfeitos e impactando os negócios de forma negativa.

<p dir="auto">Fonte: <a href="https://www.fiap.com.br/" rel="nofollow">FIAP</a></p>

## Proposta

Para solucionar o problema, a lanchonete irá investir em um sistema de autoatendimento de fast food, que é composto por uma série de dispositivos e interfaces que permitem aos clientes selecionar e fazer pedidos sem precisar interagir com um atendente. E, para que isso aconteça, criamos um sistema de controle de pedidos robusto e eficiente para a lanchonete em expansão, visando otimizar o atendimento ao cliente e garantir uma gestão adequada dos pedidos e estoques. A arquitetura do sistema será centrada em um aplicativo de autoatendimento intuitivo, permitindo que os clientes personalizem seus pedidos de maneira fácil e rápida, escolhendo lanches, acompanhamentos, bebidas e sobremesas.

Nesse primeiro momento o sistema integrará apenas com a opção de pagamento via QR Code do Mercado Pago, porém no futuro poderão ser implementadas novas opções de pagamento com o objetivo de proporcionar uma maior flexibilidade aos clientes. 

A escalabilidade será um ponto-chave na arquitetura, permitindo que o sistema se adapte facilmente ao aumento e diminuição da demanda. Utilizamos as melhores tecnologias e práticas disponíveis no mercado para assegurar a eficiência operacional mesmo em momentos de alta demanda. A arquitetura sistêmica e de infraestrutura facilitará futuras atualizações e integrações no sistema.

# Documentação

<h4 tabindex="-1" dir="auto" data-react-autofocus="true">Stack</h4>

<p>
  <a target="_blank" rel="noopener noreferrer nofollow" href="https://camo.githubusercontent.com/ffd9b9f100120fd49ebdbe8064adec834a0927f7be93551d12804c85fb92a298/68747470733a2f2f696d672e736869656c64732e696f2f62616467652f432532332d3233393132303f7374796c653d666f722d7468652d6261646765266c6f676f3d637368617270266c6f676f436f6c6f723d7768697465"><img src="https://camo.githubusercontent.com/ffd9b9f100120fd49ebdbe8064adec834a0927f7be93551d12804c85fb92a298/68747470733a2f2f696d672e736869656c64732e696f2f62616467652f432532332d3233393132303f7374796c653d666f722d7468652d6261646765266c6f676f3d637368617270266c6f676f436f6c6f723d7768697465" data-canonical-src="https://img.shields.io/badge/CSHARP-6A5ACD.svg?style=for-the-badge&amp;logo=csharp&amp;logoColor=white" style="max-width: 100%;"></a>
  <a target="_blank" rel="noopener noreferrer nofollow" href="https://camo.githubusercontent.com/71ae40a5c68bd66e1cb3813f84a5b71dd3c270c8f2506143d33be1c23f0b0783/68747470733a2f2f696d672e736869656c64732e696f2f62616467652f2e4e45542d3531324244343f7374796c653d666f722d7468652d6261646765266c6f676f3d646f746e6574266c6f676f436f6c6f723d7768697465"><img src="https://camo.githubusercontent.com/71ae40a5c68bd66e1cb3813f84a5b71dd3c270c8f2506143d33be1c23f0b0783/68747470733a2f2f696d672e736869656c64732e696f2f62616467652f2e4e45542d3531324244343f7374796c653d666f722d7468652d6261646765266c6f676f3d646f746e6574266c6f676f436f6c6f723d7768697465" data-canonical-src="https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&amp;logo=dotnet&amp;logoColor=white" style="max-width: 100%;"></a>
  <a target="_blank" rel="noopener noreferrer nofollow" href="https://camo.githubusercontent.com/bce5c9b25447afefd9c8dc63febce5936fbff659beee51466a130b41a2821a9b/68747470733a2f2f696d672e736869656c64732e696f2f62616467652f446f636b65722d3243413545303f7374796c653d666f722d7468652d6261646765266c6f676f3d646f636b6572266c6f676f436f6c6f723d7768697465"><img src="https://camo.githubusercontent.com/bce5c9b25447afefd9c8dc63febce5936fbff659beee51466a130b41a2821a9b/68747470733a2f2f696d672e736869656c64732e696f2f62616467652f446f636b65722d3243413545303f7374796c653d666f722d7468652d6261646765266c6f676f3d646f636b6572266c6f676f436f6c6f723d7768697465" data-canonical-src="https://img.shields.io/badge/Docker-2CA5E0?style=for-the-badge&amp;logo=docker&amp;logoColor=white" style="max-width: 100%;"></a>
</p>

<details>
  <summary>Diagrama Arquitetural AWS</summary>

  ## Arquitetura AWS
A arquitetura do projeto Tech Lanches passou por uma significativa evolução nesta fase. Mudamos de uma arquitetura baseada em Docker e Kubernetes nativo para implementar nossos recursos no provedor cloud AWS, responsável pelo provisionamento, gerenciamento e segurança de nossos recursos. Nesta arquitetura AWS procuramos explorar ao máximo todos os recursos disponibilizados pelo AWS Academy fornecido pela instituição FIAP. No diagrama da arquitetura, toda a nossa infraestrutura está hospedada no ambiente AWS na região us-east-1, na Virgínia do Norte, que é a zona de disponibilidade mais econômica da AWS. Dentro dessa região temos alguns recursos que iremos explorar a seguir.

- <b>TechLanches.Auth</b>: Temos uma API Gateway que é responsável pelo fluxo de cadastro e autorização do usuário, ou seja, todas as validações relacionadas ao usuário. Implementamos duas funções Lambda: uma para o cadastro de usuários e outra para autenticação e autorização. Além disso, configuramos um bucket S3 para armazenar nossos arquivos Lambda zip. Utilizamos a função IAM ROLE padrão do AWS Academy para permitir o provisionamento automático dos recursos através do Terraform. Também integramos o Amazon Cognito para autenticação do usuário, o AWS Secrets Manager para armazenar dados confidenciais necessários para o fluxo de autenticação, e o serviço CloudWatch para monitoramento de logs das Lambdas. Para mais informações dos recursos utilizados, consulte a documentação da <b>[AWS](https://docs.aws.amazon.com/)</b>.

- <b>TechLanches.API</b>: Utilizamos uma API Gateway que lida com o mapeamento dos endpoints internos da aplicação TechLanches. Optamos por essa abordagem de ter duas API Gateway devido às restrições de alguns recursos do AWS Academy para nosso tipo de usuário, no qual este ambiente foi fornecido pela institução FIAP. Usamos o VPC Link para comunicação entre a API Gateway e o Network Load Balancer, que está dentro da VPC padrão do AWS Academy. Implementamos um Load Balancer do tipo Network para distribuir automaticamente o tráfego entre vários destinos, que está contido em uma subnet pública. Na subnet privada da API Tech Lanches, temos mais alguns recursos essenciais. O primeiro e um dos mais cruciais é o Amazon EKS, um serviço gerenciado do Kubernetes para executar o mesmo na AWS, cuidando automaticamente da disponibilidade e escalabilidade dos nodes no plano de controle. No contexto da nossa aplicação, o EKS é responsável por englobar o ecossistema, incluindo serviços como IAM Role padrão do AWS Academy para permitir o provisionamento, CloudWatch para monitoramento de logs, AWS EC2 para fornecer capacidade de computação escalonável e sob demanda, e um bucket S3 para armazenar o estado dos recursos através do arquivo terraform tfstate.

- <b>TechLanches.DB</b>: Na próxima subnet privada, está o Amazon RDS da aplicação, um banco de dados relacional na AWS com vantagens como escalabilidade, economia e capacidade de redimensionamento para um banco de dados relacional padrão, entre outros. Nessa mesma subnet, também encontramos um bucket S3 para armazenar o estado dos recursos através do arquivo terraform tfstate, e um AWS Secret Manager para guardar dados confidenciais para o funcionamento da aplicação. O RDS também recebe comunicação tanto do EKS da API Tech Lanches quanto do EKS da Fila de Pedidos.

- <b>TechLanches.FilaPedidos</b>: Na Fila de Pedidos que está contido em uma subnet privada, temos um EKS específico para o mesmo, juntamente com uma instância EC2, cujo propósito é o processamento dos pedidos. Além disso, ele recebe suporte do EKS RabbitMQ para auxiliar no alcançe do seu objetivo.

- <b>TechLanches.RabbitMQ</b>: No RabbitMQ que também está contido em uma subnet privada, temos um Application Load Balancer para acesso direto ao Dashboard do RabbitMQ que está contido em uma subnet pública. Também possuimos um serviço EKS e uma instância EC2. Esses recursos desempenham um papel crucial em apoiar a Fila de Pedidos, controlando e gerenciando o fluxo de pedidos do usuário, o que é fundamental para a eficiência dos processos.

Optamos por não utilizar múltiplas zonas de disponibilidade devido ao custo desnecessário que poderia ser gerado ao cliente. E utilizamos a ferramenta de IaC <b>[Terraform](https://www.terraform.io/)</b> para automatizar o provisionamento de todos os nossos recursos na AWS.

  <img src="https://github.com/g12-4soat/techlanches-api/blob/main/docs/fase3/arquitetura-aws.png" style="max-width: 100%;">
  
</details>

<details>
  <summary>Como executar o projeto?</summary>

## Executando o Projeto
O procedimento de inicialização do projeto é simples e leva poucos passos: 

1. Clone o repositório: _[https://github.com/g12-4soat/techlanches-infra-k8s](https://github.com/g12-4soat/techlanches-infra-k8s.git)_
 
1. Abra a pasta via linha de comando no diretório escolhido no **passo 1**. _Ex.: c:\> cd “c:/techlanches-infra-k8s”_

## Via Kubernetes
Da raiz do repositório, entre no diretório _**./k8s**_ _(onde se encontram todos os manifestos .yaml para execução no kubernetes)_, dê um duplo clique no arquivo "apply-all.sh" ou execute o seguinte comando no terminal:

### Windows 
> PS c:\techlanches-infra-k8s\k8s> sh apply-all.sh

### Unix Systems (Linux distros | MacOS)
> $ exec apply-all.sh

</details>
<details>
  <summary>Versões</summary>

## Software
- C-Sharp - 10.0
- .NET - 6.0
</details>

---
### Swagger & Redoc 
Com o projeto inicializado, você terá acesso aos links abaixo e poderá abri-los em uma aba do seu navegador:

- Swagger: [http://localhost:5050/swagger/index.html](http://localhost:5050/swagger/index.html)
- Swagger Json: [http://localhost:5050/swagger/v1/swagger.json](http://localhost:5050/swagger/v1/swagger.json)  
- Redoc: [http://localhost:5050/api-docs/index.html](http://localhost:5050/api-docs/index.html)

### Postman 
Para importar as collections do postman, basta acessar os links a seguir:
- Collection: https://github.com/g12-4soat/techlanches-api/blob/main/docs/fase3/TechLanches.postman_collection.json
- Local Environment: https://github.com/g12-4soat/techlanches-api/blob/main/docs/fase3/TechLanches-Local.postman_environment.json

> Por padrão, a API está configurada para ser executada na porta 5050. Caso tenha problemas de inicialização, verifique se a porta já está sendo utilizada.
  ---
</details>

# Dependências
- [Docker](https://docs.docker.com/desktop/)

## Pipeline Status
| Pipeline | Status |
| --- | --- | 
| Pipeline techlanches-api | [![TechLanches API](https://github.com/g12-4soat/techlanches-api/actions/workflows/pipeline.yml/badge.svg)](https://github.com/g12-4soat/techlanches-api/actions/workflows/pipeline.yml)

---

## Vídeo Explicativo da Fase 3
Abaixo está o link disponível para o vídeo explicativo que detalha a estrutura da arquitetura AWS, e como implementamos toda a nossa estrutura de DevOps e Serverless, abordando de forma clara e objetiva os principais tópicos desta fase.

Youtube: [https://youtu.be/NTaOozSo41U](https://www.youtube.com/watch?v=Ti6GN_HeHs0)

---

Visite a nossa [Wiki](https://github.com/g12-4soat/tech-lanches/wiki)

---

Documentação DDD pelo [Miro](https://miro.com/app/board/uXjVModCVvo=/?share_link_id=379818088124)

---
