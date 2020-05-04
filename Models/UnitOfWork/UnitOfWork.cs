using Models.Contexts;
using Models.Repositories;
using System;

namespace Models.UnitOfWork
{
    public class UnitOfWork : IDisposable
    {
        private LovaContext lovaContext = new LovaContext();
        private DiscussionRepository discussionRepository;
        private ForumRepository forumRepository;
        private MessageRepository messageRepository;
        private QuestionRepository questionRepository;
        private TestRepository testRepository;
        private UserRepository userRepository;
        private UserTestRepository userTestRepository;
        private VariantRepository variantRepository;

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

        public ForumRepository ForumRepository
        {
            get
            {
                if (forumRepository == null)
                {
                    forumRepository = new ForumRepository(lovaContext);
                }

                return forumRepository;
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

        public VariantRepository VariantRepository
        {
            get
            {
                if (variantRepository == null)
                {
                    variantRepository = new VariantRepository(lovaContext);
                }

                return variantRepository;
            }
        }

        public void Save() => lovaContext.SaveChanges();

        public void Dispose() => lovaContext.Dispose();
    }
}
