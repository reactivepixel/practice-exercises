import React, { Component } from "react"
import PropTypes from "prop-types"
import Link from "gatsby-link"

class Template extends Component {
  constructor(props) {
    super(props)
    this.state = {
      filterValue: "",
      liveData: []
    }
    this.captureFilter = this.captureFilter.bind(this)
  }

  captureFilter(event) {
    this.setState({ filterValue: event.target.value })
  }

  render() {
    const exampleProp = "testing!"
    return (
      <div>
        <header>
          <h1>Bosun</h1>
          <p>An interesting tagline describing the project</p>
        </header>
        <section>{this.props.children({ ...this.props })}</section>
        <footer>
          <p>Footer</p>
        </footer>
      </div>
    )
  }
}

// const TemplateWrapper = ({
//   children,
//   data: { allMarkdownRemark: { edges: pages } }
// }) => {
//   console.log("Pages", pages)
//   return (
//     <div>
//       <header>
//         <h1>Bosun</h1>
//         <p>An interesting tagline describing the project</p>
//       </header>
//       <section>{children()}</section>
//       <footer>
//         <p>Footer</p>
//       </footer>
//     </div>
//   )
// }

// TemplateWrapper.propTypes = {
//   children: PropTypes.func
// }

export default Template

export const layoutQuery = graphql`
  query LayoutQuery {
    allMarkdownRemark(limit: 1000) {
      edges {
        node {
          fields {
            slug
          }
          excerpt
          frontmatter {
            title
            difficulty
            categories
          }
        }
      }
    }
  }
`
