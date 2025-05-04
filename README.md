

# DevPulse

> **UA | EN**
> 🇺🇦 Читай нижче українською
> 🇬🇧 Scroll down for English

---

## 🧠 Що таке DevPulse (UA)

**DevPulse** — це інструмент для розробника, який:

* прийшов на новий проєкт і не розуміє, що відбувається;
* боїться зламати щось важливе;
* витрачає 3 дні на розбір одного класу;
* і при цьому постійно відволікається на чати, таски та хаос.

**DevPulse допомагає:**

* Швидко зрозуміти незнайомий код
* Знайти слабкі місця проєкту
* Працювати в фокусі без шуму
* Переглянути історію змін з контекстом
* Замінити 100 дурних питань AI-помічником

---

## 🎯 Основні можливості

* **AI-пояснення коду:**
  Виділяєш → тиснеш → читаєш пояснення.

* **Аналіз проблем у коді (code smells):**
  “Метод на 300 рядків — це треш.”

* **Контекстна історія змін:**
  “Цей файл Вася редагував 5 разів. Востаннє — два тижні тому через баг в оплаті.”

* **Фокус-мод (Pomodoro + блокування шуму):**
  Працюєш по 25 хвилин — DevPulse допомагає не відволікатись.

---

## 🧩 Архітектура: Feature-Oriented Hexagon (FOH)

DevPulse побудований на базі **FOH** — адаптованої архітектури, яка поєднує ідеї **DDD**, **Hexagonal Architecture**, та **CQS**.

### Структура:

* **Features/<FeatureName>/** — модульна бізнес-логіка, ізольована за фічами.
* **Handlers** реалізують CQS (Command/Query Separation).
* **Інтерфейси репозиторіїв** живуть поряд із логікою.
* **Infrastructure** реалізує ці інтерфейси через **EF Core** та **Repository pattern**.
* **Вхід у систему** — через **Minimal API** (чисті, легкі ендпоінти без контролерів).
* **Бізнес не залежить від інфраструктури**: все працює через абстракції.

### Принципи:

✅ CQS (розділення читання/запису)
✅ Repository для ізоляції доступу до БД
✅ Мінімальний зв’язок між модулями
✅ Висока тестованість і масштабованість
✅ Дотримання SOLID / KISS / SRP

---

## 🤝 Як долучитись

* Форкни репозиторій
* Створи гілку `feature/назва`
* Додай pull request з описом змін

---

## 📄 Ліцензія

MIT License

---

## 💬 Наостанок

DevPulse — це не ще один pet-проєкт. Це реальна відповідь на біль кожного інженера, який відкрив кодову базу і подумав:
**“WTF тут відбувається?”**

---

# DevPulse

## 🧠 What is DevPulse (EN)

**DevPulse** is a developer assistant built for engineers who:

* join a new project and feel completely lost;
* are afraid of breaking things;
* spend 3 days trying to understand a class;
* constantly get distracted by messages and chaos.

**DevPulse helps you:**

* Understand unknown code faster
* Identify weak/problematic areas in the project
* Stay focused with fewer distractions
* See who made changes and why
* Replace dozens of beginner questions with smart AI

---

## 🎯 Key Features

* **AI-powered code explanation:**
  Select → Click → Read the summary.

* **Code smell analysis:**
  "A 300-line method? Come on."

* **Context-aware change history:**
  "This file was changed 5 times by Alex. Last time — 2 weeks ago, fixing payment logic."

* **Focus mode (Pomodoro + noise block):**
  Work in 25-minute sprints without distractions.

---

## 🧩 Architecture: Feature-Oriented Hexagon (FOH)

DevPulse is built using a custom lightweight architecture — **FOH** — inspired by **DDD**, **Hexagonal Architecture**, and **CQS** principles.

### Structure:

* `Features/<FeatureName>/` — encapsulated business logic per feature
* **Handlers** follow CQS (Command/Query Separation)
* Interfaces for repositories live next to the domain logic
* **Infrastructure** implements those interfaces using **EF Core + Repository pattern**
* Entry points use **Minimal API** — no heavy controllers
* **Business logic never depends on infrastructure**

### Core Values:

✅ Clear CQS boundaries
✅ Repository for DB access isolation
✅ Minimal coupling
✅ High testability and scalability
✅ Respecting SOLID / KISS / SRP principles

---

## 🤝 Contributing

* Fork the repo
* Create a branch: `feature/your-feature`
* Submit a PR with a clean description

---

## 📄 License

MIT License

---

## 💬 Final Words

DevPulse isn’t another side project. It’s a practical solution to a real problem every engineer has faced:
**“WTF is going on in this codebase?”**

