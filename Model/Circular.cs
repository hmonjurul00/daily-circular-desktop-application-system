using System;
using System.Collections.Generic;
using System.Text;

namespace daily_circular_desktop_application_system.Model
{
    class Circular
    {
        private int circularId;
        private string title;
        private string body;
        private DateTime createdAt;
        private User createdBy;

        public Circular()
        {
        }

        public Circular(int circularId, string title, string body, DateTime createdAt, User createdBy)
        {
            this.CircularId = circularId;
            this.Title = title;
            this.Body = body;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
        }

        public int CircularId { get => circularId; set => circularId = value; }
        public string Title { get => title; set => title = value; }
        public string Body { get => body; set => body = value; }
        public DateTime CreatedAt { get => createdAt; set => createdAt = value; }
        public User CreatedBy { get => createdBy; set => createdBy = value; }
    }
}
