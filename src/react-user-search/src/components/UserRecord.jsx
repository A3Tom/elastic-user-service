import React from 'react'

const UserRecord = ({user}) => {
  return (
		<li>
            <h2>
                {user.firstName} {user.surname}
            </h2>
			<div>
				<span>{user.emailAddress}</span>
			</div>
			<div>
				<span>{user.gender}</span>
			</div>
		</li>
  );
}

export default UserRecord