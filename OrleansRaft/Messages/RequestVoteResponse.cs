namespace OrleansRaft.Messages
{
    using System;

    [Serializable]
    public class RequestVoteResponse : IMessage
    {
        public long Term { get; set; }
        public bool VoteGranted { get; set; }
    }
}