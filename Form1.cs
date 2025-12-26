using GameFrameWork;
using HallowKnight.Movements;
using System.Resources;

namespace HallowKnight
{
    public partial class Form1 : Form
    {
        Game game = new Game();
        PhysicsSystem physics = new PhysicsSystem();
        CollisionSystem collisions = new CollisionSystem();
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public Form1()
        {
            DoubleBuffered = true;
            Setting();
            InitializeComponent();
            timer1.Start();
        }



        private void Setting()
        {
            game.AddObject(new Player
            {
                Position = new PointF(100, 200),
                Size = new Size(100, 100),
                Movement = new horizontalMovement()

            });

            game.AddObject(new Player
            {
                Position = new PointF(250, 100),
                Size = new Size(100, 100),
                HasPhysics = true,
                // Movement = new PatrolMovement(left: 100, right: 500)
            });

            // A physics enabled rigid player — will stop on collision and gravity will be disabled
            game.AddObject(new Player
            {
                Position = new PointF(250, 350),
                Size = new Size(40, 40),
                IsRigidBody = false,
            });

            game.AddObject(new Enemy
            {
                Position = new PointF(300, 100),
                Size = new Size(50, 50),
                HasPhysics = false // Enable physics with default gravity
            });
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            game.Draw(e.Graphics);
        }

        
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            // Update all game objects
            game.Update(new GameTime());

            // Apply physics to all objects
            physics.Apply(game.Objects.ToList());

            // Check for collisions between objects
            collisions.Check(game.Objects.ToList());

            // Cleanup objects marked for removal
            game.Cleanup();

            // Redraw the game
            Invalidate();
        }
    }

}
