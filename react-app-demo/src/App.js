import logo from './logo.svg';
import './App.css';
import ItemsList from './components/ItemsList';
import AddItem from './components/AddItem'
import { useState, useEffect } from 'react';
import axios, * as others from 'axios';

function App() {
  const [itemsList, setProducts] = useState([]);

  const getProducts = async () => {
    const responseData = await axios.get(
      `https://localhost:7160/api/Products/GetProducts?skip=0&take=10`);

    setProducts(responseData.data)
  }

  useEffect(() => {
    getProducts();
  }, []);


  // const addItemHandler = (item) => {
  //   console.log(item);
  //   setProducts((oldList) => {return oldList.concat(item)})
  //   // itemsList.push(item);
  // }

  const addNewElementHandler = async (newElem) => {
    axios.post(
      'https://localhost:7160/api/Products/AddProduct', 
      newElem)
    .then(function (response) {
      getProducts();
    })
    .catch(function (error) {
      console.log(error);
    });
  }

  return (
    <div className='container'>
      <h2>Items list</h2>
      <ItemsList items={itemsList}/>
      <AddItem onAddItem={addNewElementHandler}/>
    </div>
  );
}

export default App;
