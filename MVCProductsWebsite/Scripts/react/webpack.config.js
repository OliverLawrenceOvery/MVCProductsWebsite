module.exports = {
    context: __dirname,
        entry: "./app.js",
        output: {
           path: __dirname + "/dist",
           filename: "bundle.js"
    },
    watch: true,
    module: {
        rules: [
            { test: /\.css$/, use: ['style-loader', 'css-loader'] },
            {
                test: /\.js$/,
                exclude: /(node_modules)/,
                use: {
                    loader: 'babel-loader',
                    options: {
                        presets: ['@babel/preset-env', '@babel/preset-react']
                    }
                }
            }
        ]
    }
}