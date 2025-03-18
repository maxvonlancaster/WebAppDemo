import logo from './logo.svg';
import './App.css';
import ItemsList from './components/ItemsList';
import AddItem from './components/AddItem'
import { useState } from 'react';

function App() {
  const [itemsList, newItem] = useState([
    {id: 1, name: "item 1"},
    {id: 2, name: "item 2"},
    {id: 3, name: "item 3"}
  ]);

  const addItemHandler = (item) => {
    console.log(item);
    newItem((oldList) => {return oldList.concat(item)})
    // itemsList.push(item);
  }

  return (
    <div className='container'>
      <h2>Items list</h2>
      <ItemsList items={itemsList}/>
      <AddItem onAddItem={addItemHandler}/>
    </div>
  );
}

export default App;
