import { defineConfig } from "vite";
import react from "@vitejs/plugin-react";
import tailwindcss from '@tailwindcss/vite'

const proxyTarget = process.env.services__server__http__0  || "http://localhost:5000"

const port = process.env.PORT ? parseInt(process.env.PORT) : 3001;
console.log("Proxying to " + proxyTarget);
// https://vitejs.dev/config/
export default defineConfig({
    plugins: [react(),tailwindcss()],
    build: {
        outDir: "../../deploy/public",
        emptyOutDir: true,
        rollupOptions: {
            output: {
                entryFileNames: `assets/[name]-[hash].js`,
                chunkFileNames: `assets/[name]-[hash].js`,
                assetFileNames: `assets/[name]-[hash].[ext]`
            },
        },
    },
    define: {
        "process.env": process.env,
        // // By default, Vite doesn't include shims for NodeJS/
        // // necessary for segment analytics lib to work
        "global": {},
    },
    server: {
        port: port,
        host: "0.0.0.0",
        proxy: {
            "/api/": {
                target: proxyTarget
                // changeOrigin: true,
            }
        },
        watch: {
            ignored: [ "**/*.fs" ]
        },
    }
});
