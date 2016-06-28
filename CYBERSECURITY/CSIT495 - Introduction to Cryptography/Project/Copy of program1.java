import java.io.File;
import java.io.FileInputStream;
import java.io.FileWriter;
import java.io.BufferedInputStream;
import java.io.BufferedWriter;
import java.io.IOException;
import java.io.InputStream;
import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;
import java.util.Formatter;

public class program1 {

  public static void main(String[] args) {

    // Make sure there are exactly 2 arguments passed to the program,
    // one for the first file directory and another for the second
    if (args.length != 2) {
      System.err.println("Incorrect program usage. Must be run as \"program1 directory1 directory2\"");
      System.exit(1);
    }

    String dir1 = args[0];

    // Get all the files and their hash values, and add to output file
    File folder = new File(dir1);
    File[] files = folder.listFiles();

    String outputFileDirectory = args[1];
    String outputFileName = outputFileDirectory + "/hashes.txt";

    try {

      FileWriter outputFileWriter = new FileWriter(outputFileName);
      BufferedWriter bufferedWriter = new BufferedWriter(outputFileWriter);

     // String currentFileName;

      for (int i = 0; i < files.length; i++) {
    	 // currentFileName = files[i].getName();

        // Compute hash value for current file
    	  String hash = program1.sha1(files[i]);

        // Add hash value to a new line in outputFile
        bufferedWriter.write(hash);
        bufferedWriter.newLine();
      }

      bufferedWriter.close();

    } catch (IOException ex) {
      System.out.println("Error writing to file '" + outputFileName + "'");
      ex.printStackTrace();
    } catch (NoSuchAlgorithmException ex){
      ex.printStackTrace();
    }

   // String dir2 = args[1];
    // Create new file that we will store in directory2 containing all the hash values

  }

  public static String sha1(final File file) throws NoSuchAlgorithmException, IOException {
	    final MessageDigest messageDigest = MessageDigest.getInstance("SHA1");

	    try (InputStream is = new BufferedInputStream(new FileInputStream(file))) {
	      final byte[] buffer = new byte[1024];
	      for (int read = 0; (read = is.read(buffer)) != -1;) {
	        messageDigest.update(buffer, 0, read);
	      }
	    }

	    // Convert the byte to hex format
	    try (Formatter formatter = new Formatter()) {
	      for (final byte b : messageDigest.digest()) {
	        formatter.format("%02x", b);
	      }
	      return formatter.toString();
	    }
	  }
}
