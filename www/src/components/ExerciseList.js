import styled from "styled-components"

const ExerciseList = styled.ul`
  list-style: none;
  padding: 0;
  margin: 0;

  display: grid;
  grid-template-columns: repeat(auto-fill, minmax(300px, 1fr));
  grid-gap: 1rem;
`

export default ExerciseList
