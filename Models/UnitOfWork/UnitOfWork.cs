using Models.Contexts;
using Models.Repositories;
using System;

namespace Models.UnitOfWork
{
    public class UnitOfWork : IDisposable
    {
        private LovaContext lovaContext = new LovaContext();
        private DiscussionRepository discussionRepository;
        private MessageRepository messageRepository;
        private QuestionRepository questionRepository;
        private TestRepository testRepository;
        private UserRepository userRepository;
        private UserTestRepository userTestRepository;

        public DiscussionRepository DiscussionRepository
        {
            get
            {
                if (discussionRepository == null)
                {
                    discussionRepository = new DiscussionRepository(lovaContext);
                }

                return discussionRepository;
            }
        }

        public MessageRepository MessageRepository
        {
            get
            {
                if (messageRepository == null)
                {
                    messageRepository = new MessageRepository(lovaContext);
                }

                return messageRepository;
            }
        }

        public QuestionRepository QuestionRepository
        {
            get
            {
                if (questionRepository == null)
                {
                    questionRepository = new QuestionRepository(lovaContext);
                }

                return questionRepository;
            }
        }

        public TestRepository TestRepository
        {
            get
            {
                if (testRepository == null)
                {
                    testRepository = new TestRepository(lovaContext);
                }

                return testRepository;
            }
        }

        public UserRepository UserRepository
        {
            get
            {
                if (userRepository == null)
                {
                    userRepository = new UserRepository(lovaContext);
                }

                return userRepository;
            }
        }

        public UserTestRepository UserTestRepository
        {
            get
            {
                if (userTestRepository == null)
                {
                    userTestRepository = new UserTestRepository(lovaContext);
                }

                return userTestRepository;
            }
        }


        public void Save() => lovaContext.SaveChanges();

        public void Dispose() => lovaContext.Dispose();
    }
}
