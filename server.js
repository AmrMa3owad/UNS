const express = require("express");
const path = require("path");

const app = express();
const PORT = process.env.PORT || 4000;

// Serve static files from the "public" directory
app.use(express.static(path.join(__dirname, "public")));

// Example API endpoint
app.get("/api/message", (req, res) => {
    res.json({ message: "Hello from Node.js backend!" });
});

// Start the server
app.listen(PORT, () => {
    console.log(`Server is running on http://localhost:${PORT}`);
});
