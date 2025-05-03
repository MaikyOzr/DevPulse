
# DevPulse

> **UA | EN**  
> 🇺🇦 Читай нижче українською  
> 🇬🇧 Scroll down for English

---

## 🧠 Що таке DevPulse (UA)

**DevPulse** — це інструмент для розробника, який:

- приходить на новий проєкт і нічого не розуміє;
- боїться щось зламати;
- витрачає 3 дні на розбір трьох файлів;
- і при цьому його постійно смикають чатами, тасками, хаосом.

**DevPulse допомагає:**
- Швидко зрозуміти незнайомий код
- Знайти проблемні місця в проекті
- Сфокусуватись без відволікань
- Побачити, хто, коли і чому вносив зміни
- Замінити 100 дурних питань AI-помічником

---

## 🎯 Основні можливості

- **AI-пояснення коду:**  
  Виділяєш — тиснеш — читаєш пояснення.

- **Аналіз проблем (code smells):**  
  “Метод на 300 рядків — це не ок.”

- **Історія змін з контекстом:**  
  “Цей файл Вася редагував 5 разів. Востаннє — 2 тижні тому.”

- **Фокус-мод (Pomodoro + блокування шуму):**  
  Працюєш по 25 хв — DevPulse не дає відволікатись.

---

## 🧩 Архітектура: Feature-Oriented Hexagon

Ми використовуємо **FOH** — мікс DDD + Hexagonal Architecture, адаптований під реальні потреби:

- Кожна фіча — окрема капсула (`Features/<FeatureName>/`)
- Бізнес-логіка всередині фічі
- Інтерфейси зберігаються там, де бізнес
- Інфраструктура — просто інструмент, не тягнеться в ядро
- Вхід/вихід = контролери та адаптери (Hexagonal style)

✅ Мінімальна зв’язність  
✅ Висока читабельність  
✅ Швидке масштабування  
✅ Чітке слідування SOLID / SRP / KISS

---

## 🤝 Як долучитись

- Форкни репозиторій
- Створи гілку `feature/назва`
- Створи pull request з описом, що змінилось

---

## 📄 Ліцензія

MIT License

---

## 💬 Наостанок

DevPulse — це не ще один pet-проєкт. Це відповідь на біль кожного інженера, який зайшов у нову кодову базу і почув у голові:  
**“WTF is going on here?”**

---

# DevPulse

## 🧠 What is DevPulse (EN)

**DevPulse** is a developer assistant built for engineers who:

- join a new project and feel lost;
- are afraid to break things;
- spend 3 days understanding 3 files;
- constantly get distracted by messages, tasks, and chaos.

**DevPulse helps you:**
- Quickly understand unfamiliar code
- Detect problem areas in the project
- Stay focused and undistracted
- See who changed what and why
- Replace dozens of beginner questions with AI help

---

## 🎯 Key Features

- **AI-powered code explanation:**  
  Select a block → Click → Get a human-friendly summary.

- **Code quality analysis (code smells):**  
  "This method has 300 lines — let’s fix that."

- **Context-aware change history:**  
  "This file was modified 5 times by John. Last time: 2 weeks ago — payment logic fix."

- **Focus mode (Pomodoro + noise blocker):**  
  Work in deep sessions — notifications muted.

---

## 🧩 Architecture: Feature-Oriented Hexagon

DevPulse uses **FOH** — a lightweight, scalable architecture inspired by DDD and Hexagonal principles.

- Each feature is isolated (`Features/<FeatureName>/`)
- Business logic lives within the feature
- Interfaces stay close to the domain
- Infrastructure is external and replaceable
- Clear input/output separation via ports & adapters

✅ Minimal coupling  
✅ High readability  
✅ Easy to scale  
✅ Strict SOLID & clean code principles

---

## 🤝 Contributing

- Fork the repo
- Create a branch: `feature/your-feature`
- Submit a PR with a clear description

---

## 📄 License

MIT License

---

## 💬 Final Words

DevPulse isn’t a weekend experiment. It’s a practical response to the real pain of reading and working with messy codebases.

If you’ve ever opened a project and thought:  
**“WTF is this?”** — DevPulse is for you.
