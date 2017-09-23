---
title: The title of your excercise
difficulty: 1
degree: WDD
outcome: null
categories:
  - Javascript
  - HTML
  - CSS
---

All exercises live in the exercises folder. The content of your exercise will go here. It should be written in [Markdown syntax](https://guides.github.com/features/mastering-markdown/) and may include images, code blocks, tables, etc. See an existing activity for an idea of the expected naming convention.

Above you'll see the frontmatter. This helps us build the activity browser page and filter activities by their metadata. Frontmatter is written in YAML syntax. The only required frontmatter properties as of this moment are title, difficulty, and categories.

- `title`: The display title of this activity.
- `difficulty`: The difficulty scale should range from 1 to 5, based on the level of time and complexity of the activity. This should be relative to it's position in the degree, not relative to the student's position.
- `degree`: Degree value should be WDD, MDD, or Central.
- `outcome`: If applicable, one of the core, degree level learning outcomes may be used. Otherwise leave this value as `null`.
- `categories`: Categories can be broad or narrow, but please limit them to only the core assessment outcomes of the exercise. For example, an exercise assessing React knowledge may also include the Javascript category, but HTML and CSS may not be the focus of the assessment. _Categories are structured in a nested YAML list as shown in this example._