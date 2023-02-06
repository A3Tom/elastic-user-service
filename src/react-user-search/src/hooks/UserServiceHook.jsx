import { useState, useEffect } from "react";

function searchUsers(searchTerm, options) {
	const [data, setData] = useState(null);
	const [error, setError] = useState(null);
	const [loading, setLoading] = useState(false);

	const baseUrl = "https://localhost:7033/api/Users/searchUsers";
	const url = `${baseUrl}?searchTerm=${searchTerm}`;

	const callApi = async () => {
		try {
            if(searchTerm!== "")
            {
                setLoading(true);
                const response = await fetch(url, options);
                const json = await response.json();
                setData(json);
                setLoading(false);
            }
		} catch (err) {
			setError(err);
			setLoading(false);
		}
	};

	useEffect(() => {
		callApi();
	}, []);

	return [data, error, loading, callApi];
}

export default searchUsers;
