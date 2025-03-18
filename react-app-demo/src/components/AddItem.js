import React, {useState} from "react";

const AddItem = props => {
    const [val, valChanged] = useState("");

    const submitItem = event => {
        // event.preventDefault();
        const newItem = {
            id: 1,
            name: val
        }
        props.onAddItem(newItem);
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