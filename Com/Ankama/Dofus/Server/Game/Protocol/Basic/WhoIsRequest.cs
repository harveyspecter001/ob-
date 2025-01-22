using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Basic
{
	// Token: 0x02000BBC RID: 3004
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class WhoIsRequest : IMessage<WhoIsRequest>, IMessage, IEquatable<WhoIsRequest>, IDeepCloneable<WhoIsRequest>, IBufferMessage
	{
		// Token: 0x17001B07 RID: 6919
		// (get) Token: 0x06009084 RID: 36996 RVA: 0x0026E85C File Offset: 0x0026CA5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<WhoIsRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B08 RID: 6920
		// (get) Token: 0x06009085 RID: 36997 RVA: 0x0026E86C File Offset: 0x0026CA6C
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

		// Token: 0x17001B09 RID: 6921
		// (get) Token: 0x06009086 RID: 36998 RVA: 0x0026E87C File Offset: 0x0026CA7C
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

		// Token: 0x06009087 RID: 36999 RVA: 0x0026E88C File Offset: 0x0026CA8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public WhoIsRequest()
		{
		}

		// Token: 0x06009088 RID: 37000 RVA: 0x0026E89C File Offset: 0x0026CA9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public WhoIsRequest(WhoIsRequest other)
		{
		}

		// Token: 0x06009089 RID: 37001 RVA: 0x0026E8AC File Offset: 0x0026CAAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public WhoIsRequest Clone()
		{
			return null;
		}

		// Token: 0x17001B0A RID: 6922
		// (get) Token: 0x0600908A RID: 37002 RVA: 0x0026E8BC File Offset: 0x0026CABC
		// (set) Token: 0x0600908B RID: 37003 RVA: 0x0026E8CC File Offset: 0x0026CACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Verbose
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001B0B RID: 6923
		// (get) Token: 0x0600908C RID: 37004 RVA: 0x0026E8DC File Offset: 0x0026CADC
		// (set) Token: 0x0600908D RID: 37005 RVA: 0x0026E8EC File Offset: 0x0026CAEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public PlayerSearch Target
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

		// Token: 0x0600908E RID: 37006 RVA: 0x0026E8FC File Offset: 0x0026CAFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600908F RID: 37007 RVA: 0x0026E90C File Offset: 0x0026CB0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(WhoIsRequest other)
		{
			return true;
		}

		// Token: 0x06009090 RID: 37008 RVA: 0x0026E91C File Offset: 0x0026CB1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009091 RID: 37009 RVA: 0x0026E92C File Offset: 0x0026CB2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009092 RID: 37010 RVA: 0x0026E93C File Offset: 0x0026CB3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009093 RID: 37011 RVA: 0x0026E94C File Offset: 0x0026CB4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009094 RID: 37012 RVA: 0x0026E95C File Offset: 0x0026CB5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009095 RID: 37013 RVA: 0x0026E96C File Offset: 0x0026CB6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(WhoIsRequest other)
		{
		}

		// Token: 0x06009096 RID: 37014 RVA: 0x0026E97C File Offset: 0x0026CB7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009097 RID: 37015 RVA: 0x0026E98C File Offset: 0x0026CB8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009098 RID: 37016 RVA: 0x0026E99C File Offset: 0x0026CB9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static WhoIsRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a3352f41efa4477a999311944d3fe01f == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bf7d4de7efe04d679a42f99a7796f60d == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						goto IL_73;
					case 4:
						return;
					}
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
				}
				IL_73:
				WhoIsRequest._parser = new MessageParser<WhoIsRequest>(() => null);
				num = 4;
			}
		}

		// Token: 0x06009099 RID: 37017 RVA: 0x0026EA6C File Offset: 0x0026CC6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lGbwqwJ2ks0JaEu95OrL()
		{
			return true;
		}

		// Token: 0x0600909A RID: 37018 RVA: 0x0026EA74 File Offset: 0x0026CC74
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static WhoIsRequest oX7M9LJ2lM9S596mMoaD()
		{
			return null;
		}

		// Token: 0x040035CD RID: 13773
		private static readonly MessageParser<WhoIsRequest> _parser;

		// Token: 0x040035CE RID: 13774
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035CF RID: 13775
		public const int VerboseFieldNumber = 1;

		// Token: 0x040035D0 RID: 13776
		private bool verbose_;

		// Token: 0x040035D1 RID: 13777
		public const int TargetFieldNumber = 2;

		// Token: 0x040035D2 RID: 13778
		private PlayerSearch target_;

		// Token: 0x040035D3 RID: 13779
		private static WhoIsRequest rLlqfFJ2IOxrVFUIetBF;
	}
}
