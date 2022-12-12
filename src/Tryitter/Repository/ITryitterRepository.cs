﻿using Tryitter.Entities;

namespace Tryitter.Repository
{
    public interface ITryitterRepository
    {
        void CreateStudent(Student student);
        void CreatePost (Post post);
        Post? GetPost (int postId);
        List<Post>? Posts(int studentId);
        void EditPost(Post post, Post updatePost);
    }
}
