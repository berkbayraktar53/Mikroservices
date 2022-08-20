# .Net 5.0 İle Microservices
- Udemy benzeri bir online kurs satış platformunu microservice mimari ile geliştireceğimiz bir proje yapıyoruz.
- Proje devam ediyor. Detayları aşağıda görebilirsiniz. 
![114802958-42c15d80-9da7-11eb-8391-ba0abf87a1b1](https://user-images.githubusercontent.com/73104871/185747481-a24c6dcf-add7-459d-b2aa-09fc7326d56c.png)
# <b>Catalog Microservice</b> 
- Kurslarımız ile ilgili bilgilerin tutulmasından ve sunulmasından sorumlu olacak mikroservisimiz.
- MongoDb (Veritabanı)
- One-To-Many/One-To-One ilişki
- MongoDb
# <b>Basket Microservice</b>
- Sepet işlemlerinden sorumlu olacak mikroservisimiz.
- RedisDB(Veritabanı)
# <b>Discount Microservice</b>
- Kullanıcıya tanımlanacak indirim kuponlarından sorumlu olacak mikroservisimiz.
- PostgreSQL(Veritabanı)
# <b>Order Microservice</b>
- Sipariş işlemlerinden sorumlu olacak mikroservisimiz.
- Bu mikroservisimizde Domain Driven Design yaklaşımını kullanarak geliştiriyor olacağız.
- Bu mikroservisimizde CQRS tasarım kalıbını uygulamak için MediatR kütüphanesini kullanıyor olacağız.
- Sql Server(Veritabanı)
- Domain Driven Design
- CQRS (MediatR Libarary)
# FakePayment Microservice
- Ödeme işlemlerinden sorumlu olacak mikroservisimiz.
# IdentityServer Microservice
- Sql Server(Veritabanı)
- Kullanıcı dataların tutulmasından,token ve refreshtoken üretilmesinden sorumlu olacak microservisimiz.
# PhotoStock Microservice
- Kurs fotograflarının tutulmasından ve sunulmasından sorumlu olacak mikroservisimiz.
# API Gateway
- Ocelot Library
# Message Broker
- Mesaj kuyruk sistemi olarak RabbitMQ kullanıyor olacağız.
- RabbitMQ ile haberleşmek için MassTransit kütüphanesini kullanıyor olacağız.
- RabbitMQ (MassTransit Library)
# Identity Server
- Token / RefreshToken üretmek
- Access Token ile microservice'lerimizi korumak
- OAuth 2.0 / OpenID Connect protokollerine uygun yapı inşa etmek
# Asp.Net Core MVC Microservice
- Microservice'lerden almış olduğu dataları kullanıcıya gösterecek ve kullanıcı ile etkileşime geçmekten sorumlu olacak UI mikroservisimiz
