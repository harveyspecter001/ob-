using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Achievement
{
	// Token: 0x02000DBD RID: 3517
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AchievementsDetailedRequest : IMessage<AchievementsDetailedRequest>, IMessage, IEquatable<AchievementsDetailedRequest>, IDeepCloneable<AchievementsDetailedRequest>, IBufferMessage
	{
		// Token: 0x17001F69 RID: 8041
		// (get) Token: 0x0600A96B RID: 43371 RVA: 0x002979B0 File Offset: 0x00295BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AchievementsDetailedRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F6A RID: 8042
		// (get) Token: 0x0600A96C RID: 43372 RVA: 0x002979C0 File Offset: 0x00295BC0
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

		// Token: 0x17001F6B RID: 8043
		// (get) Token: 0x0600A96D RID: 43373 RVA: 0x002979D0 File Offset: 0x00295BD0
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

		// Token: 0x0600A96E RID: 43374 RVA: 0x002979E0 File Offset: 0x00295BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AchievementsDetailedRequest()
		{
		}

		// Token: 0x0600A96F RID: 43375 RVA: 0x002979F0 File Offset: 0x00295BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AchievementsDetailedRequest(AchievementsDetailedRequest other)
		{
		}

		// Token: 0x0600A970 RID: 43376 RVA: 0x00297A00 File Offset: 0x00295C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AchievementsDetailedRequest Clone()
		{
			return null;
		}

		// Token: 0x17001F6C RID: 8044
		// (get) Token: 0x0600A971 RID: 43377 RVA: 0x00297A10 File Offset: 0x00295C10
		// (set) Token: 0x0600A972 RID: 43378 RVA: 0x00297A20 File Offset: 0x00295C20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CategoryId
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

		// Token: 0x0600A973 RID: 43379 RVA: 0x00297A30 File Offset: 0x00295C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A974 RID: 43380 RVA: 0x00297A40 File Offset: 0x00295C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AchievementsDetailedRequest other)
		{
			return true;
		}

		// Token: 0x0600A975 RID: 43381 RVA: 0x00297A50 File Offset: 0x00295C50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A976 RID: 43382 RVA: 0x00297A60 File Offset: 0x00295C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A977 RID: 43383 RVA: 0x00297A70 File Offset: 0x00295C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A978 RID: 43384 RVA: 0x00297A80 File Offset: 0x00295C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A979 RID: 43385 RVA: 0x00297A90 File Offset: 0x00295C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A97A RID: 43386 RVA: 0x00297AA0 File Offset: 0x00295CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AchievementsDetailedRequest other)
		{
		}

		// Token: 0x0600A97B RID: 43387 RVA: 0x00297AB0 File Offset: 0x00295CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A97C RID: 43388 RVA: 0x00297AC0 File Offset: 0x00295CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A97D RID: 43389 RVA: 0x00297AD0 File Offset: 0x00295CD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AchievementsDetailedRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1255b6ea0c3b4bc59d153e0b78ee5a99 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_46b15fddf6c94445bea2053db8105f1b != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_affdd3418c6040e883e142bf711593a7 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					AchievementsDetailedRequest._parser = new MessageParser<AchievementsDetailedRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47f1b3c36e024d4bb84ccbe58986ef1e == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x0600A97E RID: 43390 RVA: 0x00297BC8 File Offset: 0x00295DC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zQSIGEJcgyi9gOURkOSS()
		{
			return true;
		}

		// Token: 0x0600A97F RID: 43391 RVA: 0x00297BD0 File Offset: 0x00295DD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AchievementsDetailedRequest TbtJSuJcsqUDfu3OZAjZ()
		{
			return null;
		}

		// Token: 0x04003E46 RID: 15942
		private static readonly MessageParser<AchievementsDetailedRequest> _parser;

		// Token: 0x04003E47 RID: 15943
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E48 RID: 15944
		public const int CategoryIdFieldNumber = 1;

		// Token: 0x04003E49 RID: 15945
		private int categoryId_;

		// Token: 0x04003E4A RID: 15946
		internal static AchievementsDetailedRequest cV7yFaJcG60GXM4gPigD;
	}
}
