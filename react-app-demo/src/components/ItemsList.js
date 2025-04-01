import React from "react";

const ItemsList = props => {
  console.log(props.items);

    return (
        <ul className='items-list'>
          {props.items.map((item) => {return <li>{item.name}, {item.description}</li>})}
      </ul>
    )
}

export default ItemsList;