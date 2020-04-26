const resolvers = {
    Widget: {
        async gadgets( /*parent*/ { id }, /*args*/ _, { Service2 }) {
            return await Service2.api.gadgets({
                parentId: id,
            });
        }
    }
};

module.exports = { resolvers };