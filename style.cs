body {
  margin: 0;
  font-family: 'Poppins', sans-serif;
  background-color: #fef9f4;
  color: #333;
}

header {
  display: flex;
  justify-content: space-between;
  align-items: center;
  padding: 1rem 2rem;
  background: linear-gradient(to right, #b24592, #f15f79);
  color: white;
  position: sticky;
  top: 0;
  z-index: 999;
}

.logo {
  font-family: 'Playfair Display', serif;
  font-size: 1.8rem;
  font-weight: 600;
}
.logo-img {
  height: 50px;
  width: auto;
  border-radius: 50%;
}

nav a {
  margin: 0 1rem;
  color: white;
  text-decoration: none;
  font-weight: 500;
}

.hero {
  padding: 4rem 2rem;
  text-align: center;
  background: linear-gradient(to right, #ffecd2, #fcb69f);
  font-family:'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif
}

.hero h1 {
  font-family: 'Playfair Display', serif;
  font-size: 2.8rem;
  margin-bottom: 1rem;
font-family: Verdana, Geneva, Tahoma, sans-serif;
}

.cta-btn {
  display: inline-block;
  margin-top: 1rem;
  padding: 0.8rem 1.5rem;
  background: #b24592;
  color: #fff;
  border-radius: 5px;
  text-decoration: none;
  font-weight: 600;
}

.section {
  padding: 4rem 2rem;
  text-align: center;
}

.section h2 {
  font-family: 'Playfair Display', serif;
  font-size: 2.2rem;
  color: #444;
}

.section-text {
  margin-bottom: 2rem;
  max-width: 600px;
  margin-left: auto;
  margin-right: auto;
}
.profile-img {
  width: 100%;
  height: 180px;
  object-fit: cover;
  border-radius: 10px 10px 0 0;
  margin-bottom: 10px;
}

.profile-cards,
.packages {
  display: flex;
  justify-content: center;
  flex-wrap: wrap;
  gap: 1.5rem;
  margin-top: 2rem;
}

.card {
  background: white;
  padding: 1.5rem;
  border-radius: 10px;
  box-shadow: 0 4px 15px rgba(0, 0, 0, 0.1);
  width: 200px;
  font-weight: 500;
  transition: transform 0.3s ease;
  padding: 20px;
      background: #fff;
      border-radius: 10px;
      text-align: center;
      font-size: 1.1rem;
      box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1);
      transition: transform 0.3s ease;
      user-select: none;
    
}
.card {
  user-select: none;
  /* ❌ Text select disable */
  -webkit-user-select: none;
  /* For Safari */
  -moz-user-select: none;
  /* For Firefox */
  -ms-user-select: none;
  /* For IE/Edge */
}

.card:hover {
  transform: translateY(-8px);
}

.gold {
  border-left: 5px solid gold;
}

.platinum {
  border-left: 5px solid silver;
}

.elite {
  border-left: 5px solid #b09fff;
}

.gallery {
  display: grid;
  grid-template-columns: repeat(auto-fit, minmax(220px, 1fr));
  gap: 20px;
  margin-top: 30px;
}

.img-box {
  overflow: hidden;
  border-radius: 12px;
  box-shadow: 0 4px 15px rgba(0, 0, 0, 0.15);
  transition: transform 0.3s ease, box-shadow 0.3s ease;
}

.img-box img {
  width: 100%;
  height: 100%;
  object-fit: cover;
  display: block;
  transition: transform 0.3s ease;
}

/* Hover effect */
.img-box:hover {
  transform: translateY(-5px);
  box-shadow: 0 8px 20px rgba(0, 0, 0, 0.25);
}

.img-box:hover img {
  transform: scale(1.05);
}

/* About Section */
.about-paragraph {
  max-width: 750px;
  margin: 3rem auto;
  font-size: 1.15rem;
  background: #fff5f8;
  padding: 2rem;
  border-radius: 10px;
  font-family: 'Georgia', serif;
  line-height: 1.8;
  box-shadow: 0 5px 20px rgba(0, 0, 0, 0.05);
  color: #444;
}

/* Contact Section */
.contact-section {
  background: linear-gradient(to right, #2c2c2c, #1e1e1e);
  color: #f5f5f5;
  padding: 3rem 2rem;
  text-align: center;
}

.contact-section h2 {
  font-family: 'Playfair Display', serif;
  font-size: 2.2rem;
  color: #fcb69f;
  margin-bottom: 1rem;
}

.contact-section p {
  font-size: 1.1rem;
  max-width: 600px;
  margin: 0 auto 2rem auto;
  color: #ccc;
}

.contact-buttons {
  display: flex;
  justify-content: center;
  gap: 1rem;
  flex-wrap: wrap;
}

.whatsapp-btn,
.call-btn {
  padding: 0.8rem 1.6rem;
  border-radius: 30px;
  text-decoration: none;
  font-weight: 600;
  font-size: 1rem;
  color: white;
  background: #27ae60;
  transition: all 0.3s ease;
}

.call-btn {
  background: #2980b9;
}

.whatsapp-btn:hover {
  background: #2ecc71;
}

.call-btn:hover {
  background: #3498db;
}

footer {
  text-align: center;
  padding: 2rem;
  background: #111;
  color: #aaa;
  font-size: 0.95rem;
  line-height: 1.5;
}

@media (max-width: 768px) {
  header {
    height: 5vh;
    padding: 2vh;
  }
  
  nav {
    margin-top: 2rem;
  }

.hero {
  padding: 4rem 3rem;
  text-align: center;
  background: linear-gradient(to right, #ffecd2, #fcb69f);
}

.hero h1 {
  font-family: 'Playfair Display', serif;
  font-size: 2.8rem;
  margin-bottom: 1rem;
  font-family: Verdana, Geneva, Tahoma, sans-serif;
}
  .profile-cards,
  .packages {
    flex-direction: column;
    align-items: center;
  }
/* Contact Section */
.contact-section {
  background: linear-gradient(to right, #2c2c2c, #1e1e1e);
  color: #f5f5f5;
  padding: 1rem 1rem;
  text-align: center;
}

.contact-section h2 {
  font-family: 'Playfair Display', serif;
  font-size: 2.3rem;
  color: #fcb69f;
  margin-bottom: 1rem;
}

.contact-section p {
  font-size: 1rem;
  max-width: 600px;
  margin: 0 auto 2rem auto;
  color: #ccc;
}
  .contact-buttons {
    flex-direction: column;
    align-items: center;
    
  }

  .about-paragraph {
    padding: 1.5rem;
  }
}
/* Hamburger button */
.menu-toggle {
  display: none;
  font-size: 2rem;
  background: none;
  border: none;
  color: white;
  cursor: pointer;
}

/* Mobile responsive navbar */
@media (max-width: 768px) {
  .menu-toggle {
    display: block;
  }

  nav {
    display: none;
    flex-direction: column;
    width: 48%;
    background: #682c56;
    position: absolute;
    top: 7.5vh;
    left:50%;
    border-radius: 2vh;
    padding:  0;
    z-index: 999;
    border-top: 2px solid #fdfcfb;
    font-family:Arial, Helvetica, sans-serif
  }

  nav.show {
    display: flex;
  }

  nav a {
    padding: 0.8rem 1rem;
    border-bottom: 1px solid rgba(255, 255, 255, 0.3);
    text-align: center;
  }
}

