import React from 'react';
import axios from "axios";

export function Home() {

	const fetchSomeData = () => {
		axios.get("api/example")
			.then(response => {
				console.log(response);
			});
	}

	return (
		<div>
			<h1>Hello, world!</h1>

			<button onClick={fetchSomeData}>Fetch some data?</button>
		</div>
	);
}

export default Home;