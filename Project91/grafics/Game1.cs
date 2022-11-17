using System.Collections.Generic;
using System.Windows.Forms;
using ArbolBinarioDeBusqueda.DBQueries;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame;
using MySql.Data.MySqlClient;
using Project91;
using ButtonState = Microsoft.Xna.Framework.Input.ButtonState;
using Keys = Microsoft.Xna.Framework.Input.Keys;
using MessageBox = System.Windows.Forms.MessageBox;


namespace grafics {
    public class Game1 : Game {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private SpriteFont _spriteFont;
        private Texture2D _cero;
        private Texture2D _uno;
        private Texture2D _dos;
        private Texture2D _tres;
        private Texture2D _cuatro;
        private Texture2D _cinco;
        private Texture2D _seis;
        private Texture2D _siete;
        private Texture2D _ocho;
        private Texture2D _nueve;
        private Texture2D[] _listaTexturas;
        int cont = 0;
        int dato = 0;
        int datb = 0;
        int cont2 = 0;
        Dtree arbolAVL = new Dtree(null);
        Dtree arbolAVL_Letra = new Dtree(null);
        ///Graphics g;
        //int pintaR = 0;
        public Game1() {
            _graphics = new GraphicsDeviceManager(this);
            _graphics.PreferredBackBufferWidth = Screen.PrimaryScreen.WorkingArea.Width - 100;
            _graphics.PreferredBackBufferHeight = 800;
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            Window.AllowUserResizing = true;
        }

        protected override void Initialize() {
            // TODO: Add your initialization logic here
            /*arbolAVL.Insertar(47);
            cont++;
            arbolAVL.Insertar(6);
            cont++;
            arbolAVL.Insertar(37);
            cont++;
            arbolAVL.Insertar(1);
            cont++;
            arbolAVL.Insertar(72);
            cont++;
            arbolAVL.Insertar(2);
            cont++;*/

            MySqlDataReader dataReader = LoadData.GetValues();
            List<int> datos = new List<int>();

            while (dataReader.Read()) {
                arbolAVL.Insertar(dataReader.GetInt32(0));
            }

            base.Initialize();
        }

        protected override void LoadContent() {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            _spriteFont = Content.Load<SpriteFont>("File");
            _cero = Content.Load<Texture2D>("0");
            _uno = Content.Load<Texture2D>("1");
            _dos = Content.Load<Texture2D>("2");
            _tres = Content.Load<Texture2D>("3");
            _cuatro = Content.Load<Texture2D>("4");
            _cinco = Content.Load<Texture2D>("5");
            _seis = Content.Load<Texture2D>("6");
            _siete = Content.Load<Texture2D>("7");
            _ocho = Content.Load<Texture2D>("8");
            _nueve = Content.Load<Texture2D>("9");
            _listaTexturas = new Texture2D[] { _cero, _uno, _dos, _tres, _cuatro, _cinco, _seis, _siete, _ocho, _nueve };

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime) {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime) {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here


            _spriteBatch.Begin();

            arbolAVL.DibujarArbol(_graphics, _spriteBatch, 20, _spriteFont, _listaTexturas);


            //MonoGame.Primitives2D.DrawCircle(_spriteBatch, new Vector2(40, 60), 40, 52, Color.Black);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}