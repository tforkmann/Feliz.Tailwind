import { defineConfig } from "vite";
import react from "@vitejs/plugin-react";
import tailwindcss from '@tailwindcss/vite'

/** @type {import('vite').UserConfig} */

export default defineConfig(({ command, mode }) => {
    var isDev = command === 'serve'
    return {
            plugins: [react(), tailwindcss()],
            base: isDev ? undefined : '/Feliz.Tailwind/',
            root: "./src/Docs",
            server: {
            port: 8080,
            proxy: {
            '/api': 'http://localhost:5000',
        }
        },
            build: {
            outDir:"../../publish/docs"
        }

    }
})