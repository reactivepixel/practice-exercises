module.exports = {
  siteMetadata: {
    title: "Title"
  },
  pathPrefix: "/practice-exercises",
  plugins: [
    "gatsby-plugin-styled-components",
    {
      resolve: "gatsby-source-filesystem",
      options: {
        name: "pages",
        path: `${__dirname}/src/pages/`
      }
    },
    {
      resolve: "gatsby-source-filesystem",
      options: {
        name: "exercises",
        path: `${__dirname}/../exercises/`
      }
    },
    "gatsby-transformer-remark"
  ]
}
