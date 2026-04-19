# Atividade AmericanAirlinesSkyApi

## Nome: Alice Barros Viana

### Cadastrando Aeronave:

<img width="462" height="363" alt="image" src="https://github.com/user-attachments/assets/15cc096a-d95a-4698-a5e0-2a443bfeb4d4" />

### Cadastrando Voo:

<img width="467" height="277" alt="image" src="https://github.com/user-attachments/assets/e0fb6c7a-69b4-46c0-9e62-7535b04449ab" />

### Cadastrando 2 Reservas: 

<img width="544" height="265" alt="image" src="https://github.com/user-attachments/assets/facb5cc5-4ed2-47de-aad4-5f50c7022223" />
<br>

<img width="514" height="173" alt="image" src="https://github.com/user-attachments/assets/784e9672-537a-497f-b65a-ab85c8850c12" />

### Tentando Cadastrar a 3 reserva: 

<img width="554" height="148" alt="image" src="https://github.com/user-attachments/assets/82f71e0b-6236-4e9c-9d28-1a5c4e1a7cbc" />

## Pensamento Crítico
##### Pergunta;
Em um sistema de reservas global como o da American Airlines, como você
garantiria que dois usuários em países diferentes não reservem o mesmo
assento no exato mesmo segundo? Pesquise sobre 'Optimistic Concurrency'
ou 'Pessimistic Locking' e escreva um parágrafo sobre.

##### Resposta:
Em um sistema de reservas mundial como o da American Airlines, a forma de evitar que duas pessoas em países diferentes peguem o mesmo assento ao mesmo tempo é usar técnicas de concorrência. O Optimistic Concurrency funciona deixando todo mundo tentar reservar e, na hora de confirmar, o sistema checa se alguém já pegou aquele assento. Se sim, a segunda tentativa dá erro e a pessoa precisa escolher outro. Já o Pessimistic Locking trava o assento assim que alguém começa a reservar, impedindo qualquer outro de mexer até terminar. No dia a dia, o Optimistic costuma ser mais usado porque é rápido e escala bem, mas em situações críticas o Pessimistic pode ser aplicado para garantir que não haja conflito.



