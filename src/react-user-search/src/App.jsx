import { useState } from "react"

import SearchBar from "./components/SearchBar";
import UserList from "./components/UserList";

function App() {
    const [usersFound, setUsersFound] = useState([]);

    const updateUserList = (users) => {
        console.log(users)
        setUsersFound(users);
    }

    return (
		<div className="container">
			<header>
				<h1>User Search</h1>
			</header>
			<div className="search-container">
				<SearchBar setUsersFound={updateUserList} />
			</div>
            {usersFound && <UserList users={usersFound}/>}
		</div>
	);
}

export default App
