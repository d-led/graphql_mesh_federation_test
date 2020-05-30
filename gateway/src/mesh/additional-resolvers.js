module.exports = {
    Widget: {
        gadgets: {
            selectionSet: `{ id }`,
            resolve: ( /*parent*/ { id }, /*args*/ _, { Service2 }) => Service2.api.gadgets({
                parentId: id,
            }),
        }
    }
};