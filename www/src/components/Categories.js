import styled from "styled-components"
import { colors } from "../config"
const CategoryList = styled.ul`
  color: ${colors.base};
  padding: 0;
  margin: 0;
  list-style: none;
  display: flex;
  flex-wrap: wrap;
  font-size: ${p => p.size || "1rem"};
`

const CategoryItem = styled.li`
  padding: 0.25rem 1rem;
  margin: 0.25rem;
  border-radius: 0.5rem;
  text-align: center;
  background-color: ${p =>
    p.active ? p.color || colors.blue : colors.greyLight};
  color: ${p => (p.active ? colors.white : colors.base)};
`

export { CategoryItem, CategoryList }
