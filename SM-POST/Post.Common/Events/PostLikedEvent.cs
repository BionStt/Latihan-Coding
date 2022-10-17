using CQRS.Core.Events;

namespace Post.Common.Events
{
    public class PostLikedEvent : BaseEvent
    {
        public PostLikedEvent() : base(nameof(PostLikedEvent))
        {
        }
       // public string MyProperty { get; set; }
        //public string MyProperty { get; set; }
    }
}