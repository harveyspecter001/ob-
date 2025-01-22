using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Admin.Console
{
	// Token: 0x02000DB2 RID: 3506
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ConsoleMessage : IMessage<ConsoleMessage>, IMessage, IEquatable<ConsoleMessage>, IDeepCloneable<ConsoleMessage>, IBufferMessage
	{
		// Token: 0x17001F55 RID: 8021
		// (get) Token: 0x0600A8F9 RID: 43257 RVA: 0x002962C8 File Offset: 0x002944C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ConsoleMessage> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F56 RID: 8022
		// (get) Token: 0x0600A8FA RID: 43258 RVA: 0x002962D8 File Offset: 0x002944D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F57 RID: 8023
		// (get) Token: 0x0600A8FB RID: 43259 RVA: 0x002962E8 File Offset: 0x002944E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600A8FC RID: 43260 RVA: 0x002962F8 File Offset: 0x002944F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ConsoleMessage()
		{
		}

		// Token: 0x0600A8FD RID: 43261 RVA: 0x00296308 File Offset: 0x00294508
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ConsoleMessage(ConsoleMessage other)
		{
		}

		// Token: 0x0600A8FE RID: 43262 RVA: 0x00296318 File Offset: 0x00294518
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ConsoleMessage Clone()
		{
			return null;
		}

		// Token: 0x17001F58 RID: 8024
		// (get) Token: 0x0600A8FF RID: 43263 RVA: 0x00296328 File Offset: 0x00294528
		// (set) Token: 0x0600A900 RID: 43264 RVA: 0x00296338 File Offset: 0x00294538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Content
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001F59 RID: 8025
		// (get) Token: 0x0600A901 RID: 43265 RVA: 0x00296348 File Offset: 0x00294548
		// (set) Token: 0x0600A902 RID: 43266 RVA: 0x0029635C File Offset: 0x0029455C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsoleMessage.Types.Type Type
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (ConsoleMessage.Types.Type)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x0600A903 RID: 43267 RVA: 0x0029636C File Offset: 0x0029456C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A904 RID: 43268 RVA: 0x0029637C File Offset: 0x0029457C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ConsoleMessage other)
		{
			return true;
		}

		// Token: 0x0600A905 RID: 43269 RVA: 0x0029638C File Offset: 0x0029458C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A906 RID: 43270 RVA: 0x0029639C File Offset: 0x0029459C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A907 RID: 43271 RVA: 0x002963AC File Offset: 0x002945AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A908 RID: 43272 RVA: 0x002963BC File Offset: 0x002945BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A909 RID: 43273 RVA: 0x002963CC File Offset: 0x002945CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A90A RID: 43274 RVA: 0x002963DC File Offset: 0x002945DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ConsoleMessage other)
		{
		}

		// Token: 0x0600A90B RID: 43275 RVA: 0x002963EC File Offset: 0x002945EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A90C RID: 43276 RVA: 0x002963FC File Offset: 0x002945FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A90D RID: 43277 RVA: 0x0029640C File Offset: 0x0029460C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ConsoleMessage()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					ConsoleMessage._parser = new MessageParser<ConsoleMessage>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ccea45e828ca4ede894a726afe0a41ea == 0)
					{
						num2 = 3;
					}
					break;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0cf81502393c4abba92bedafaef205c1 != 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_788ea967924b4fae800c9ff0efe6ebc0 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		// Token: 0x0600A90E RID: 43278 RVA: 0x00296504 File Offset: 0x00294704
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool L4f1HUJlZjxxom0ZRxEV()
		{
			return true;
		}

		// Token: 0x0600A90F RID: 43279 RVA: 0x0029650C File Offset: 0x0029470C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ConsoleMessage dfAQsbJlqdLiMeuVHCOC()
		{
			return null;
		}

		// Token: 0x04003E1D RID: 15901
		private static readonly MessageParser<ConsoleMessage> _parser;

		// Token: 0x04003E1E RID: 15902
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E1F RID: 15903
		public const int ContentFieldNumber = 1;

		// Token: 0x04003E20 RID: 15904
		private string content_;

		// Token: 0x04003E21 RID: 15905
		public const int TypeFieldNumber = 2;

		// Token: 0x04003E22 RID: 15906
		private ConsoleMessage.Types.Type type_;

		// Token: 0x04003E23 RID: 15907
		private static ConsoleMessage cu8GjvJl8VvUQZnDXH9y;

		// Token: 0x02000DB3 RID: 3507
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x0600A910 RID: 43280 RVA: 0x002F1A64 File Offset: 0x002EFC64
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000DB4 RID: 3508
			public enum Type
			{
				// Token: 0x04003E25 RID: 15909
				[OriginalName("TEXT")]
				Text,
				// Token: 0x04003E26 RID: 15910
				[OriginalName("INFO")]
				Info,
				// Token: 0x04003E27 RID: 15911
				[OriginalName("ERROR")]
				Error
			}
		}
	}
}
