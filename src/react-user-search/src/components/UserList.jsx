import UserRecord from './UserRecord'

const UserList = ({users}) => {
  return (
    <ul className='user-list'>
        {users.sort((a, b) => a.firstname > b.firstname)
        .map((user) => (
            <UserRecord key={user.emailAddress} user={user}/>
        ))}
    </ul>
  )
}

export default UserList