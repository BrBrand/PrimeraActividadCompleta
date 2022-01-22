using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tercer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FriendController : ControllerBase
    {
        // GET: api/Friend
        [HttpGet]
        public List<Friend> Get()
        {
            List<Friend> friends = new List<Friend>();
            friends.Add(new Friend("Kindson", "Munonye", "Budapest", DateTime.Today));
            friends.Add(new Friend("Oleander", "Yuba", "Nigeria", DateTime.Today));
            friends.Add(new Friend("Saffron", "Lawrence", "Lagos", DateTime.Today));
            friends.Add(new Friend("Jadon", "Munonye", "Asaba", DateTime.Today));
            friends.Add(new Friend("Solace", "Okeke", "Oko", DateTime.Today));

            return friends;
        }

        [HttpGet("{id}", Name = "Get")]
        public Friend Get(int id)
        {
            Friend friend = friend.Find(friend => f.id == id);
            return friend;

        }

        // POST api/<FriendController>
        [HttpPost]
        public List <Friend> Post([FromBody] Friend friend)
        {
            friends.Add(friend);
            return friends;

        }

        // PUT api/<FriendControllers>/5
        [HttpPut("{id}")]
        public List<Friend> Put(int id, [FromBody] Friend friend)
        {
            Friend friendToUpdate = friends.Find(friend => f.id == id);
            int index = friends.IndexOf(friendToUpdate);

            friend[index].firstname = friend.firstname;
            friend[index].lastname = friend.lastname;
            friend[index].location = friend.location;
            friend[index].dateOfHire = friend.dateOfHire;
            return friends;

        }

        // DELETE api/<FriendControllers>/5
        [HttpDelete("{id}")]
        public List<Friend> Delete(int id)
        {
            Friend friend = friends.Find(friend => f.id == id);
            friends.Remove(friend);
            return friends;
        }

     
       
    }


}
