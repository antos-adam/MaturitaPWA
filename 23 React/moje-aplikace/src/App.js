import logo from './logo.svg';
import './App.css';
import { useState } from "react";
import ExampleComponent from "./ExampleComponent"; // import nové komponenty

function App() {
	const [count, setCount] = useState(0); // použití state

	const clickHandler = () => {
		setCount(count + 1); // zvýšení count o 1
	}

	return (
		<div className="App">
			<header className="App-header">
				<img src={logo} className="App-logo" alt="logo" />


				<button onClick={clickHandler}>Click me</button>


				{/* předání count do nové komponenty */}
				<ExampleComponent count={count}></ExampleComponent>
			</header>
		</div>
	);
}

export default App;
