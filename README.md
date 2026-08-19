# ELP Language Trainer

A desktop language-learning application designed to help students learn and practice vocabulary in any language they choose.

The application allows users to create separate vocabulary collections for different languages, add and manage words, import and export vocabulary data, translate unfamiliar words, and test their knowledge through randomized vocabulary quizzes.

## Overview

ELP is built around a simple idea:

> **The student controls what they learn, how they organize it, and how they test themselves.**

For example, a student learning English can create an English vocabulary collection and add words such as:

| Word | Translation |
|---|---|
| destruction | تدمير |
| assignments | مهام |
| extensible | توسع |
| pure | نقي |
| collection | مجموعة |

The same student can create another language and manage its vocabulary independently.

## Main Features

### 🏠 Home

The main page provides access to the application's different sections and acts as the central navigation point.

### ➕ Add Words

Students can add vocabulary to the selected language.

Each word can be stored together with its translation, allowing the student to build a personalized vocabulary database based on the words they encounter while studying.

### 📚 Words Management

The Words page displays the vocabulary belonging to the selected language.

Students can:

- View all saved words.
- Edit existing words.
- Delete words.
- Select the language whose vocabulary they want to manage.

Each language maintains its own separate vocabulary collection.

### 🌍 Multiple Languages

Students can create and manage more than one language.

For example:

- English
- German
- French
- Spanish
- Turkish

Words belonging to one language remain separated from words belonging to another language.

### 🧪 Vocabulary Test

The Test page allows students to test themselves using the vocabulary they have already saved.

The student:

1. Selects a language.
2. Specifies how many words they want to test.
3. Starts the test.
4. Receives a randomly selected word.
5. Enters the translation.
6. Submits the answer.
7. The application evaluates the answer.
8. Correct answers are added to the correct-answer results.
9. Incorrect answers are added to the incorrect-answer results.
10. The student continues until the selected number of words has been completed.

This turns the vocabulary database into a personal testing system rather than simply a word list.

### 🌐 Translation

The application includes a dedicated translation page.

If a student encounters a word they do not remember, they can use the application's translator instead of leaving the program to search for a translation elsewhere.

### 📥 Import

Students can import vocabulary data into the application.

This makes it possible to:

- Restore previously exported vocabulary.
- Transfer vocabulary between installations.
- Add large vocabulary collections without entering every word manually.

### 📤 Export

Students can export their vocabulary data.

This provides a way to:

- Back up vocabulary.
- Transfer data.
- Keep an external copy of their learning material.
- Reuse vocabulary in another environment.

### 🆕 Create a Language

Students can add a new language to the application.

Each language has its own independent vocabulary collection, allowing the same application to be used for learning multiple languages.

## Application Structure

The application is organized into the following main sections:

```text
ELP
│
├── Home
│
├── Enter
│   └── Add vocabulary
│
├── Words
│   ├── View words
│   ├── Edit words
│   └── Delete words
│
├── Test
│   ├── Select language
│   ├── Select number of words
│   ├── Answer questions
│   ├── Correct answers
│   └── Incorrect answers
│
├── Translate
│   └── Translate unfamiliar words
│
├── Import
│   └── Import vocabulary data
│
├── Export
│   └── Export vocabulary data
│
└── Create
    └── Create a new language
```

## Typical User Workflow

A typical learning session can look like this:

```text
Create a language
       ↓
Add vocabulary
       ↓
Review vocabulary
       ↓
Edit / delete words when necessary
       ↓
Take a vocabulary test
       ↓
Review correct and incorrect answers
       ↓
Add or practice more vocabulary
       ↓
Export data for backup
```

## Data Management

Vocabulary is organized by language rather than being stored as one large collection.

Conceptually:

```text
Language
│
├── Word
│   └── Translation
│
├── Word
│   └── Translation
│
└── Word
    └── Translation
```

This separation makes it possible to use the same application for multiple languages without mixing their vocabulary.

## Import & Export

The import/export functionality is intended to make vocabulary portable.

A student can export their vocabulary, keep it as a backup, and later import it again.

This is particularly useful when a student has spent significant time building a personal vocabulary collection.

## Screenshots

### Words Management

The Words page provides a table for viewing and managing vocabulary.

### Vocabulary Test

The Test page allows the student to select a language, choose the number of words, and practice their vocabulary.

```markdown
![Vocabulary Test](docs/screenshots/test.png)
```

## Project Goals

The project focuses on providing a simple and practical vocabulary-learning workflow without forcing students to follow a predefined vocabulary list.

The student creates their own learning material and can continuously:

- Build vocabulary.
- Organize vocabulary by language.
- Review vocabulary.
- Test their knowledge.
- Track correct and incorrect answers during a test.
- Import existing vocabulary.
- Export vocabulary for backup or transfer.

## Future Improvements

Possible future improvements include:

- Persistent test statistics.
- Learning progress tracking.
- Difficulty levels.
- Spaced repetition.
- Search and filtering.
- Vocabulary categories.
- Pronunciation and text-to-speech.
- More advanced translation options.
- Test history.
- Performance statistics and charts.
- Configurable quiz rules.
- Additional import/export formats.

## Project Status

This project is a personal language-learning application focused on vocabulary management, practice, and testing.
