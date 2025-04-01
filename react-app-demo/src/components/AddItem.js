import React, {useState} from "react";

const AddItem = props => {
    const [val, valChanged] = useState("");

    const submitItem = async (event) => {
        // event.preventDefault();
        const newItem = {
            name: val,
            description: val,
            shippingDate: Date.UTC(),
            categoryId: 2
        }
        await props.onAddItem(newItem);
        valChanged("")
    }

    const changheValue = event => {
        valChanged(event.target.value);
    }

    return (<div>
        <input type="text" value={val} onChange={changheValue}/>
        <button type="submit" onClick={submitItem}>Add item</button>
    </div>)
    
}

export default AddItem;