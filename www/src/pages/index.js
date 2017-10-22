import React from "react"
import Link from "gatsby-link"

export default function Index({ data }) {
  const { edges: exercises } = data.allMarkdownRemark
  return (
    <main>
      <h1>Practice Excercises</h1>
      <ul>
        {exercises.map(({ node: exercise }) => (
          <li key={exercise.id}>
            <Link to={exercise.fields.slug}>{exercise.frontmatter.title}</Link>
          </li>
        ))}
      </ul>
    </main>
  )
}

export const pageQuery = graphql`
  query IndexQuery {
    allMarkdownRemark {
      edges {
        node {
          id
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
