import React from "react"

export default function Template({ data }) {
  const { markdownRemark: post } = data
  return (
    <article>
      <h1>{post.frontmatter.title}</h1>
      <div className="" dangerouslySetInnerHTML={{ __html: post.html }} />
    </article>
  )
}

export const pageQuery = graphql`
  query ExerciseByPath($path: String!) {
    markdownRemark(fields: { slug: { eq: $path } }) {
      html
      frontmatter {
        title
        difficulty
        categories
      }
    }
  }
`
