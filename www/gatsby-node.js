const path = require(`path`)

exports.createPages = ({ graphql, boundActionCreators }) => {
  const { createPage } = boundActionCreators
  const exerciseTemplate = path.resolve(`src/templates/exercise.js`)
  return graphql(`{
          allMarkdownRemark(
            limit: 1000
          ) {
            edges {
              node {
                fields {
                  slug
                }
                frontmatter {
                  title
                  difficulty
                  categories
                }
              }
            }
          }
        }
          `).then(result => {
    if (result.errors) {
      return Promise.reject(result.errors)
    }

    result.data.allMarkdownRemark.edges.forEach(({ node }) => {
      createPage({
        path: node.fields.slug,
        component: exerciseTemplate,
        context: {}
      })
    })
  })
}
// Create slugs for exercise files
exports.onCreateNode = ({ node, boundActionCreators, getNode }) => {
  const { createNodeField } = boundActionCreators
  let slug

  if (node.internal.type === "MarkdownRemark") {
    const parsedFilePath = path.parse(node.fileAbsolutePath)

    if (parsedFilePath.name !== ``) {
      slug = `/exercises/${parsedFilePath.name}/`
      console.log(slug)
      createNodeField({ node, name: `slug`, value: slug })
    }
  }
}
