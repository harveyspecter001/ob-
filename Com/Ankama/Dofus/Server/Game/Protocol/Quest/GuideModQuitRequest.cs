using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Quest
{
	// Token: 0x020001A3 RID: 419
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuideModQuitRequest : IMessage<GuideModQuitRequest>, IMessage, IEquatable<GuideModQuitRequest>, IDeepCloneable<GuideModQuitRequest>, IBufferMessage
	{
		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06001376 RID: 4982 RVA: 0x001A47B0 File Offset: 0x001A29B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GuideModQuitRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06001377 RID: 4983 RVA: 0x001A47C0 File Offset: 0x001A29C0
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

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06001378 RID: 4984 RVA: 0x001A47D0 File Offset: 0x001A29D0
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

		// Token: 0x06001379 RID: 4985 RVA: 0x001A47E0 File Offset: 0x001A29E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuideModQuitRequest()
		{
		}

		// Token: 0x0600137A RID: 4986 RVA: 0x001A47F0 File Offset: 0x001A29F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuideModQuitRequest(GuideModQuitRequest other)
		{
		}

		// Token: 0x0600137B RID: 4987 RVA: 0x001A4800 File Offset: 0x001A2A00
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuideModQuitRequest Clone()
		{
			return null;
		}

		// Token: 0x0600137C RID: 4988 RVA: 0x001A4810 File Offset: 0x001A2A10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600137D RID: 4989 RVA: 0x001A4820 File Offset: 0x001A2A20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuideModQuitRequest other)
		{
			return true;
		}

		// Token: 0x0600137E RID: 4990 RVA: 0x001A4830 File Offset: 0x001A2A30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600137F RID: 4991 RVA: 0x001A4840 File Offset: 0x001A2A40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001380 RID: 4992 RVA: 0x001A4850 File Offset: 0x001A2A50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001381 RID: 4993 RVA: 0x001A4860 File Offset: 0x001A2A60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001382 RID: 4994 RVA: 0x001A4870 File Offset: 0x001A2A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001383 RID: 4995 RVA: 0x001A4880 File Offset: 0x001A2A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuideModQuitRequest other)
		{
		}

		// Token: 0x06001384 RID: 4996 RVA: 0x001A4890 File Offset: 0x001A2A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001385 RID: 4997 RVA: 0x001A48A0 File Offset: 0x001A2AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x001A48B0 File Offset: 0x001A2AB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuideModQuitRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_5E;
					case 2:
						GuideModQuitRequest._parser = new MessageParser<GuideModQuitRequest>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2d2589a17466462b8f45c545634b0246 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_954df8e9eca7464ab016741f95fe1be2 != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 4:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 3;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a3352f41efa4477a999311944d3fe01f != 0)
						{
							num2 = 3;
							continue;
						}
						continue;
					}
					return;
				}
				IL_5E:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 2;
			}
		}

		// Token: 0x06001387 RID: 4999 RVA: 0x001A4998 File Offset: 0x001A2B98
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kPwFrlOoUBXtB2CqKj4P()
		{
			return true;
		}

		// Token: 0x06001388 RID: 5000 RVA: 0x001A49A0 File Offset: 0x001A2BA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuideModQuitRequest ku0v5pOovYKREoQo7mfA()
		{
			return null;
		}

		// Token: 0x040006FB RID: 1787
		private static readonly MessageParser<GuideModQuitRequest> _parser;

		// Token: 0x040006FC RID: 1788
		private UnknownFieldSet _unknownFields;

		// Token: 0x040006FD RID: 1789
		private static GuideModQuitRequest SAXylTOocXjec5a8CeRC;
	}
}
