import React, { Component } from "react"
import Link from "gatsby-link"
import { injectGlobal } from "styled-components"
import { colors } from "../config"
import {
  ExerciseList,
  ExerciseItem,
  CategoryList,
  CategoryItem
} from "../components"

injectGlobal`
  * {
  
  }
  html {
    font-family: -apple-system, BlinkMacSystemFont, "Segoe UI", Roboto, Oxygen-Sans, Ubuntu, Cantarell, "Helvetica Neue", sans-serif;
    font-size: 16px;
  }

  a {
    text-decoration: none;
    color: ${colors.blue}
  }

`

class Index extends Component {
  constructor(props) {
    super(props)
    this.state = {
      exercises: props.data.allMarkdownRemark.edges,
      categoryFilter: "all",
      difficultyFilter: "all"
    }
  }
  categories(nodes) {
    const output = []
    // console.log(nodes)
    nodes.forEach(({ node: node }) => {
      if (node.frontmatter.categories) {
        node.frontmatter.categories.forEach(cat => {
          if (!output.includes(cat)) {
            output.push(cat)
          }
        })
      }
    })
    return output
  }

  filterByCategory(data, category) {
    if (category === "all") {
      return data
    }
    return data.filter(({ node: item }) => {
      return item.frontmatter.categories.includes(category)
    })
  }

  setCategoryFilter(category) {
    this.setState(prev => ({ categoryFilter: category }))
  }

  renderExercises(exercises, categoryFilter) {
    return this.filterByCategory(exercises, categoryFilter).map(
      ({ node: exercise }, index, arr) =>
        arr && (
          <ExerciseItem key={exercise.id}>
            <Link to={exercise.fields.slug}>
              <h3>{exercise.frontmatter.title}</h3>
            </Link>
            <p style={{ minHeight: `6rem` }}>{exercise.excerpt}</p>
            <CategoryList size=".75rem">
              {exercise.frontmatter.categories.map((cat, idx) => (
                <CategoryItem key={idx}>{cat}</CategoryItem>
              ))}
            </CategoryList>
          </ExerciseItem>
        )
    )
  }

  render() {
    const exercises = this.props.data.allMarkdownRemark.edges
    return (
      <main>
        <h2>Categories</h2>
        <CategoryList>
          <CategoryItem
            onClick={() => this.setCategoryFilter("all")}
            active={this.state.categoryFilter === "all"}
          >
            All
          </CategoryItem>
          {this.categories(exercises).map((cat, id) => (
            <CategoryItem
              key={id}
              onClick={() => this.setCategoryFilter(cat)}
              active={this.state.categoryFilter === cat}
            >
              {cat}
            </CategoryItem>
          ))}
        </CategoryList>
        <h2>Exercises</h2>
        <ExerciseList>
          {this.renderExercises(exercises, this.state.categoryFilter)}
        </ExerciseList>
      </main>
    )
  }
}

export default Index

export const pageQuery = graphql`
  query IndexQuery {
    allMarkdownRemark {
      edges {
        node {
          id
          excerpt
          fields {
            slug
          }
          frontmatter {
            title
            categories
            difficulty
          }
        }
      }
    }
  }
`
