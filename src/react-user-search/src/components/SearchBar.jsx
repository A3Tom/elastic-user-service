import { useState } from 'react'

import searchUsers from '../hooks/UserServiceHook'

const SearchBar = ({setUsersFound}) => {

    const [searchTerm, setSearchTerm] = useState("");
    const [response, error, loading, callApi] = searchUsers(searchTerm, { method: "GET" });

    const handleSubmit = async (event) => {
        event.preventDefault();
        await callApi();
        setUsersFound(response)
        setSearchTerm("");
    };
    
    return (
		<form onSubmit={handleSubmit}>
			<div>
				<input
					type="text"
					id="searchTerm"
					value={searchTerm}
					onInput={(e) => setSearchTerm(e.target.value)}
					required
					autoFocus
					maxLength={80}
					placeholder="Search for a user by first name, last name or email"
				/>
			</div>
		</form>
	);
}

export default SearchBar