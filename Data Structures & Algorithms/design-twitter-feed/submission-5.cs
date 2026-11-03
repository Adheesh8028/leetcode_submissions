public class Twitter {  
     private int time = 0;
     private Dictionary<int, List<Tweet>> tweets = new Dictionary<int, List<Tweet>>();
     private Dictionary<int, HashSet<int>> following = new Dictionary<int, HashSet<int>>();

     public class Tweet{
      public int tweetId;
      public int time;

      public Tweet(int id, int timecheck){
       tweetId = id;
       time = timecheck;
      }
    }
    public Twitter() {
        
    }
    
    public void PostTweet(int userId, int tweetId) {

        if(!tweets.ContainsKey(userId)){
            tweets[userId] = new List<Tweet>();
        }
        tweets[userId].Add(new Tweet(tweetId, time++));
    }
    
    public List<int> GetNewsFeed(int userId) {
        List<Tweet> allTweets = new();
        if(tweets.ContainsKey(userId)){
            allTweets.AddRange(tweets[userId]);
        }
        if(following.ContainsKey(userId)){
           foreach(int followeeId in following[userId]){
            if(tweets.ContainsKey(followeeId)){
                allTweets.AddRange(tweets[followeeId]);
            }
           }
        }
        allTweets.Sort((a,b) => b.time.CompareTo(a.time));

        return allTweets.Take(10).Select(t => t.tweetId).ToList();
    }
    
    public void Follow(int followerId, int followeeId) {
        if(followerId == followeeId)return;

        if(!following.ContainsKey(followerId)){
            following[followerId] = new HashSet<int>();
        }
        following[followerId].Add(followeeId);
    }
    
    public void Unfollow(int followerId, int followeeId) {
        if(following.ContainsKey(followerId)){
            following[followerId].Remove(followeeId);
        }
    }
}
