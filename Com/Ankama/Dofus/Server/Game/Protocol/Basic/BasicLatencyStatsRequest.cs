using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Basic
{
	// Token: 0x02000BC0 RID: 3008
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BasicLatencyStatsRequest : IMessage<BasicLatencyStatsRequest>, IMessage, IEquatable<BasicLatencyStatsRequest>, IDeepCloneable<BasicLatencyStatsRequest>, IBufferMessage
	{
		// Token: 0x17001B10 RID: 6928
		// (get) Token: 0x060090BA RID: 37050 RVA: 0x0026EC78 File Offset: 0x0026CE78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BasicLatencyStatsRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B11 RID: 6929
		// (get) Token: 0x060090BB RID: 37051 RVA: 0x0026EC88 File Offset: 0x0026CE88
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

		// Token: 0x17001B12 RID: 6930
		// (get) Token: 0x060090BC RID: 37052 RVA: 0x0026EC98 File Offset: 0x0026CE98
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

		// Token: 0x060090BD RID: 37053 RVA: 0x0026ECA8 File Offset: 0x0026CEA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BasicLatencyStatsRequest()
		{
		}

		// Token: 0x060090BE RID: 37054 RVA: 0x0026ECB8 File Offset: 0x0026CEB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BasicLatencyStatsRequest(BasicLatencyStatsRequest other)
		{
		}

		// Token: 0x060090BF RID: 37055 RVA: 0x0026ECC8 File Offset: 0x0026CEC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BasicLatencyStatsRequest Clone()
		{
			return null;
		}

		// Token: 0x17001B13 RID: 6931
		// (get) Token: 0x060090C0 RID: 37056 RVA: 0x0026ECD8 File Offset: 0x0026CED8
		// (set) Token: 0x060090C1 RID: 37057 RVA: 0x0026ECE8 File Offset: 0x0026CEE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Latency
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060090C2 RID: 37058 RVA: 0x0026ECF8 File Offset: 0x0026CEF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060090C3 RID: 37059 RVA: 0x0026ED08 File Offset: 0x0026CF08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(BasicLatencyStatsRequest other)
		{
			return true;
		}

		// Token: 0x060090C4 RID: 37060 RVA: 0x0026ED18 File Offset: 0x0026CF18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060090C5 RID: 37061 RVA: 0x0026ED28 File Offset: 0x0026CF28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060090C6 RID: 37062 RVA: 0x0026ED38 File Offset: 0x0026CF38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060090C7 RID: 37063 RVA: 0x0026ED48 File Offset: 0x0026CF48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060090C8 RID: 37064 RVA: 0x0026ED58 File Offset: 0x0026CF58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060090C9 RID: 37065 RVA: 0x0026ED68 File Offset: 0x0026CF68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(BasicLatencyStatsRequest other)
		{
		}

		// Token: 0x060090CA RID: 37066 RVA: 0x0026ED78 File Offset: 0x0026CF78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060090CB RID: 37067 RVA: 0x0026ED88 File Offset: 0x0026CF88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060090CC RID: 37068 RVA: 0x0026ED98 File Offset: 0x0026CF98
		[MethodImpl(MethodImplOptions.NoInlining)]
		static BasicLatencyStatsRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					BasicLatencyStatsRequest._parser = new MessageParser<BasicLatencyStatsRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_788ea967924b4fae800c9ff0efe6ebc0 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_49584b71853e42899c7da5fbe454bd16 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x060090CD RID: 37069 RVA: 0x0026EE64 File Offset: 0x0026D064
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool eBoDdoJ21qQ7rogEEoR7()
		{
			return true;
		}

		// Token: 0x060090CE RID: 37070 RVA: 0x0026EE6C File Offset: 0x0026D06C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BasicLatencyStatsRequest Na1Z4hJ2aMvWgakuqVAs()
		{
			return null;
		}

		// Token: 0x040035DD RID: 13789
		private static readonly MessageParser<BasicLatencyStatsRequest> _parser;

		// Token: 0x040035DE RID: 13790
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035DF RID: 13791
		public const int LatencyFieldNumber = 1;

		// Token: 0x040035E0 RID: 13792
		private int latency_;

		// Token: 0x040035E1 RID: 13793
		internal static BasicLatencyStatsRequest c188fwJ2olqZqMjw60bA;
	}
}
