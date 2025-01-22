using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Document
{
	// Token: 0x020007DD RID: 2013
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OpenGuideBookEvent : IMessage<OpenGuideBookEvent>, IMessage, IEquatable<OpenGuideBookEvent>, IDeepCloneable<OpenGuideBookEvent>, IBufferMessage
	{
		// Token: 0x170011D9 RID: 4569
		// (get) Token: 0x0600626C RID: 25196 RVA: 0x00222CB0 File Offset: 0x00220EB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<OpenGuideBookEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170011DA RID: 4570
		// (get) Token: 0x0600626D RID: 25197 RVA: 0x00222CC0 File Offset: 0x00220EC0
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

		// Token: 0x170011DB RID: 4571
		// (get) Token: 0x0600626E RID: 25198 RVA: 0x00222CD0 File Offset: 0x00220ED0
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

		// Token: 0x0600626F RID: 25199 RVA: 0x00222CE0 File Offset: 0x00220EE0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OpenGuideBookEvent()
		{
		}

		// Token: 0x06006270 RID: 25200 RVA: 0x00222CF0 File Offset: 0x00220EF0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OpenGuideBookEvent(OpenGuideBookEvent other)
		{
		}

		// Token: 0x06006271 RID: 25201 RVA: 0x00222D00 File Offset: 0x00220F00
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OpenGuideBookEvent Clone()
		{
			return null;
		}

		// Token: 0x170011DC RID: 4572
		// (get) Token: 0x06006272 RID: 25202 RVA: 0x00222D10 File Offset: 0x00220F10
		// (set) Token: 0x06006273 RID: 25203 RVA: 0x00222D20 File Offset: 0x00220F20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int ArticleId
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

		// Token: 0x06006274 RID: 25204 RVA: 0x00222D30 File Offset: 0x00220F30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006275 RID: 25205 RVA: 0x00222D40 File Offset: 0x00220F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(OpenGuideBookEvent other)
		{
			return true;
		}

		// Token: 0x06006276 RID: 25206 RVA: 0x00222D50 File Offset: 0x00220F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006277 RID: 25207 RVA: 0x00222D60 File Offset: 0x00220F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006278 RID: 25208 RVA: 0x00222D70 File Offset: 0x00220F70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006279 RID: 25209 RVA: 0x00222D80 File Offset: 0x00220F80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600627A RID: 25210 RVA: 0x00222D90 File Offset: 0x00220F90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600627B RID: 25211 RVA: 0x00222DA0 File Offset: 0x00220FA0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(OpenGuideBookEvent other)
		{
		}

		// Token: 0x0600627C RID: 25212 RVA: 0x00222DB0 File Offset: 0x00220FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600627D RID: 25213 RVA: 0x00222DC0 File Offset: 0x00220FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600627E RID: 25214 RVA: 0x00222DD0 File Offset: 0x00220FD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static OpenGuideBookEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					OpenGuideBookEvent._parser = new MessageParser<OpenGuideBookEvent>(() => null);
					num2 = 4;
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b1afd787bbcb47c0becd53e79f55ec2b == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_65a4bcb260b64c5f8f7680ba04c739cd != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x0600627F RID: 25215 RVA: 0x00222EB4 File Offset: 0x002210B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GLYIZxOF0UO7puODRgTx()
		{
			return true;
		}

		// Token: 0x06006280 RID: 25216 RVA: 0x00222EBC File Offset: 0x002210BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static OpenGuideBookEvent pNRe2ZOFCrowds6103DF()
		{
			return null;
		}

		// Token: 0x0400229C RID: 8860
		private static readonly MessageParser<OpenGuideBookEvent> _parser;

		// Token: 0x0400229D RID: 8861
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400229E RID: 8862
		public const int ArticleIdFieldNumber = 1;

		// Token: 0x0400229F RID: 8863
		private int articleId_;

		// Token: 0x040022A0 RID: 8864
		internal static OpenGuideBookEvent Nqt6UcOFV2cZWnBTa3Q3;
	}
}
