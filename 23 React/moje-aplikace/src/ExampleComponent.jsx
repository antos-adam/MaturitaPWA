
// první varianta
function ExampleComponent({ count }) { // získání count přes props -> první varianta
	return (
		<p>Počet kliknutí: {count}</p>
	);
}


// druhá varianta
// function ExampleComponent(props) { // získání count přes props -> druhá varianta
// 	return (
// 		<p>Počet kliknutí: {props.count}</p>
// 	);
// }

export default ExampleComponent;
